using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Google.Apis.Auth;
using CompanyManagementSystem.API.Utils.Auth;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using static Google.Apis.Auth.GoogleJsonWebSignature;
using CompanyManagementSystem.API.Services;
using CompanyManagementSystem.Data.Entities;
using System;
using CompanyManagementSystem.API.Services.Users;
using CompanyManagementSystem.API.Services.Roles;

namespace CompanyManagementSystem.API.Controllers
{
    #pragma warning disable CS8604
    [ApiController]
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        // * Once the user is logged in, each subsequent request will include the JWT, allowing the user to access routes, services, and resources that are permitted with that token.

        private readonly IConfiguration configuration;
        private readonly JwtGenerator jwtGenerator;
        private readonly IUserService userService;
        private readonly IRoleService roleService;

        public AccountController(IConfiguration _configuration, IUserService _userService, IRoleService _roleService)
        {
            this.roleService = _roleService;
            this.userService = _userService;
            this.configuration = _configuration;
            this.jwtGenerator = new JwtGenerator(configuration["JwtPrivateSigningKey"]);
        }

        [HttpGet("init")]
        public IActionResult Init()
        {
            return Ok();
        }

        // * This endpoint will be called before calling secured endpoint

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest authenticateRequest)
        {
            // GoogleJsonWebSignature ValidationSettings
            ValidationSettings settings = new ValidationSettings
            {
                Audience = new List<string>() { configuration["Google:ClientId"] }
            };

            // Validate incoming JWT and get payload information
            GoogleJsonWebSignature.Payload googlePayload = GoogleJsonWebSignature.ValidateAsync(authenticateRequest.IdToken, settings).Result;

            var email = googlePayload.Email;
            var user = userService.GetUserByEmail(email);

            // ! HANDLE LOGOUT ON FRONT IF 401 IS RETURNED
            if (user == null || user.IsDeleted)
            {
                return Unauthorized(new
                {
                    Code = 401,
                    Message = "Unauthorized",
                    Details = "User is not registered on the system"
                });
            }

            var userId = user.Id.ToString();
            var roleName = roleService.GetRoleNameById(user.Id);
            var positionName = user.WorkingPosition.Name;

            // constructing new jwt
            var token = jwtGenerator.GenerateAuthToken(userId, email, roleName, positionName);

            return Ok(token);
        }
    }
}