using System;
using Microsoft.AspNetCore.Mvc;
using CompanyManagementSystem.API.Services.Benefits;
using CompanyManagementSystem.API.Models;
using CompanyManagementSystem.API.enums;
using CompanyManagementSystem.API.Services.Skills;
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
    public class ConfigurationController : ControllerBase
    {
        private IBenefitService benefitService;
        private ISkillService skillService;
        private IWorkingPositionService workingPositionService;
        private ILanguageService languageService;

        public ConfigurationController(IBenefitService _benefitService,
        ISkillService _skillService,
        IWorkingPositionService _workingPositionService,
        ILanguageService _languageService)
        {
            this.benefitService = _benefitService;
            this.skillService = _skillService;
            this.workingPositionService = _workingPositionService;
            this.languageService = _languageService;
        }

        [HttpPost("insertion/{code}")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult InsertIntoConfiguration([FromBody] NameBaseDto nameBase, string code)
        {
            var response = new Object();
            if(code.ToLower() == ConfigurationCodes.Benefit.ToString().ToLower())
                response =  benefitService.Insert(nameBase);
            else if(code.ToLower() == ConfigurationCodes.Skill.ToString().ToLower())
                response = skillService.Insert(nameBase);
            else if(code.ToLower() == ConfigurationCodes.Language.ToString().ToLower())
                response =  languageService.Insert(nameBase);
            else if(code.ToLower() == ConfigurationCodes.Position.ToString().ToLower())
                response = workingPositionService.Insert(nameBase);

            try 
            {
                if(response.GetType().GetProperty("Code").Equals(400))
                    return BadRequest(response);

                return Ok(response);
            } catch (NullReferenceException)
            {
                return BadRequest(new Response<NameBaseDto>(ResponseMessages.ConfigCodeMissingOrWrong.ToDescription(), null, (int)ResponseCodes.BadRequest));
            }    
            
        }

        [HttpGet("information/{code}")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult GetAll(string code)
        {
            if(code.ToLower() == ConfigurationCodes.Benefit.ToString().ToLower())
                return Ok(benefitService.GetAllBenefits());
            else if(code.ToLower() == ConfigurationCodes.Skill.ToString().ToLower())
                return Ok(skillService.GetAllSkills());
            else if(code.ToLower() == ConfigurationCodes.Language.ToString().ToLower())
                return Ok(languageService.GetAllLanguages());
            else if(code.ToLower() == ConfigurationCodes.Position.ToString().ToLower())
                return Ok(workingPositionService.GetAllPositions());

            return BadRequest(new Response<NameBaseDto>(ResponseMessages.ConfigCodeMissingOrWrong.ToDescription(), null, (int)ResponseCodes.BadRequest));
        }

        [HttpGet("information/{code}/{id:int}")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult GetById(string code, int id)
        {
            var response = new Object();
            if(code.ToLower() == ConfigurationCodes.Benefit.ToString().ToLower())
                response = benefitService.GetById(id);
            else if(code.ToLower() == ConfigurationCodes.Skill.ToString().ToLower())
                response = skillService.GetById(id);
            else if(code.ToLower() == ConfigurationCodes.Language.ToString().ToLower())
                response = languageService.GetById(id);
            else if(code.ToLower() == ConfigurationCodes.Position.ToString().ToLower())
                response = workingPositionService.GetById(id);

            try
            {
                if(response.GetType().GetProperty("Code").Equals(200))
                    return Ok(response);
                return BadRequest(response);
            } catch(NullReferenceException)
            {
                 return BadRequest(new Response<NameBaseDto>(ResponseMessages.ConfigCodeMissingOrWrong.ToDescription(), null, (int)ResponseCodes.BadRequest));
            }
        }

        [HttpDelete("deletion/{code}/{id:int}")]
        [AuthorizeRoles(Roles.Administrator, Roles.Employee)]
        public IActionResult SoftDelete(string code, int id)
        {
            var response = new Object();
            if(code.ToLower() == ConfigurationCodes.Benefit.ToString().ToLower())
                response = benefitService.SoftDelete(id);
            else if(code.ToLower() == ConfigurationCodes.Skill.ToString().ToLower())
                response = skillService.SoftDelete(id);
            else if(code.ToLower() == ConfigurationCodes.Language.ToString().ToLower())
                response = languageService.SoftDelete(id);
            else if(code.ToLower() == ConfigurationCodes.Position.ToString().ToLower())
                response = workingPositionService.SoftDelete(id);

            try
            {
                if (response.GetType().GetProperty("Code").Equals(400))
                    return BadRequest(response);
                return Ok(response);
            } catch(NullReferenceException)
            {
                return BadRequest(new Response<NameBaseDto>(ResponseMessages.ConfigCodeMissingOrWrong.ToDescription(), null, (int)ResponseCodes.BadRequest));
            }
        }
    }
}