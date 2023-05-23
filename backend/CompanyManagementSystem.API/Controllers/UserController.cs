using System;
using Microsoft.AspNetCore.Mvc;
using CompanyManagementSystem.API.Services.Benefits;
using CompanyManagementSystem.API.Models;
using CompanyManagementSystem.API.enums;
using CompanyManagementSystem.API.Services.Users;
using CompanyManagementSystem.API.Services.Languages;
using CompanyManagementSystem.API.Services.WorkingPositions;
using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.Data.Extensions;
using CompanyManagementSystem.API.Utils.Auth;
using CompanyManagementSystem.Data.Enums;
using Microsoft.AspNetCore.Authorization;

namespace CompanyManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            this.userService = _userService;
        }

        [HttpGet("information/{id:int}")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult GetById(int id)
        {
            var response = userService.GetById(id);
            if(response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }
        [HttpGet("information")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult GetAllUsers()
        {
            var response = userService.GetAllUsers();
            if(response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }
        [HttpGet("information/active")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult GetAllNonDeletedUsers()
        {
            var response = userService.GetAllNonDeletedUsers();
            if(response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete("deletion/{id:int}")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult SoftDelete(int id)
        {
            var response = userService.SoftDelete(id);
            if (response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("insertion")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult Insert([FromBody] Models.UserRegister user)
        {
            var response = userService.Insert(user);
            if (response.Code.Equals(201))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("update")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult Update([FromBody] Models.UserUpdate user)
        {
            var response = userService.Update(user);
            if (response.Code.Equals(201))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("update/self")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult UpdateSelf([FromBody] Models.UserSelfUpdate user)
        {
            var response = userService.SelfUpdate(user);
            if (response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [AuthorizeRoles(Roles.Administrator)]
        [HttpPut("update/benefit/{selected:bool}")]
        public IActionResult UpdateUserBenefit(
            [FromBody] Models.UserBenefit userBenefitDTO,
            bool selected
        )
        {
            return Ok(userService.UpdateUserBenefit(userBenefitDTO, selected));
        }
    }
}