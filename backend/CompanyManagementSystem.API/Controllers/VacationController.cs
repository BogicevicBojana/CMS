using System;
using CompanyManagementSystem.API.Services.Benefits;
using CompanyManagementSystem.API.Services.Vacations;
using CompanyManagementSystem.API.Utils.Auth;
using CompanyManagementSystem.Data.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models = CompanyManagementSystem.API.Models;

namespace RBT.CompanyManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
    [AllowAnonymous]
    public class VacationController : ControllerBase
    {
        private IVacationService vacationService;

        public VacationController(IVacationService _vacationService)
        {
            this.vacationService = _vacationService;
        }


        [HttpGet("information")]
        public IActionResult GetAllBenefits()
        {
            return Ok(vacationService.GetAll());
        }

        [HttpPost("insertion")]
        public IActionResult Insert([FromBody] Models.InsertVacation vacation)
        {
            var response = vacationService.Insert(vacation);
            if ( response.Code.Equals(201))
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete("deletion/{id:int}")]
        public IActionResult Remove(int id)
        {
            var response = vacationService.RemoveVacation(id);
            if(response.Code.Equals(400))
                return BadRequest(response);
            return Ok(response);
        }
    }
}