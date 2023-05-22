using System;
using CompanyManagementSystem.API.Services.Benefits;
using CompanyManagementSystem.API.Utils.Auth;
using CompanyManagementSystem.Data.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RBT.CompanyManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
    [AllowAnonymous]
    public class BenefitController : ControllerBase
    {
        private IBenefitService benefitService;

        public BenefitController(IBenefitService _benefitService)
        {
            this.benefitService = _benefitService;
        }

        // * Get Benefit
        [HttpGet("information")]
        public IActionResult GetAllBenefits()
        {
            return Ok(benefitService.GetAllBenefits());
        }

        [HttpGet("information/{userId:int}")]
        public IActionResult GetAllBenefitsWithUser(int userId)
        {
            return Ok(benefitService.GetAllWithUser(userId));
        }
    }
}