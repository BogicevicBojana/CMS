using System;
using Microsoft.AspNetCore.Mvc;
using CompanyManagementSystem.API.Services.Users;
using CompanyManagementSystem.API.Utils.Auth;
using CompanyManagementSystem.Data.Enums;
using Microsoft.AspNetCore.Authorization;

namespace CompanyManagementSystem.API.Controllers
{
#pragma warning disable
    [ApiController]
    [Route("[controller]")]
    [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
    // [AllowAnonymous]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            this.userService = _userService;
        }

        [HttpGet("information/{id:int}")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            var response = userService.GetById(id);
            if (response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("information")]
        [Authorize]
        public IActionResult GetAllUsers()
        {
            var response = userService.GetAllUsers();
            if (response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("information/active")]
        [Authorize]
        public IActionResult GetAllNonDeletedUsers()
        {
            var response = userService.GetAllNonDeletedUsers();
            if (response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete("deletion/{id:int}")]
        [Authorize]
        public IActionResult SoftDelete(int id)
        {
            var response = userService.SoftDelete(id);
            if (response.Code.Equals(200))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("insertion")]
        [Authorize]
        public IActionResult Insert([FromBody] Models.UserRegister user)
        {
            var response = userService.Insert(user);
            if (response.Code.Equals(201))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("update")]
        [Authorize]
        public IActionResult Update([FromBody] Models.UserUpdate user)
        {
            var response = userService.Update(user);
            if (response.Code.Equals(201))
                return Ok(response);
            return BadRequest(response);
        }

        [Authorize]
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