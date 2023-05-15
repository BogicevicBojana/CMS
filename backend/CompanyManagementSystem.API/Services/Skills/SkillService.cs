using System;
using System.Collections.Generic;
using System.Linq;
using CompanyManagementSystem.DataAccess;
using CompanyManagementSystem.Data.Entities;
using Models = CompanyManagementSystem.API.Models;
using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.API.Services.Skills
{
    public class SkillService : ISkillService
    {
        private IUnitOfWork unitOfWork;

        public SkillService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public Response<List<Models.Skill>> GetAllSkills()
        {
            var skills = unitOfWork.skillRepository.GetAllSkills();

            List<Models.Skill> mapped = new List<Models.Skill>();
            foreach (var skill in skills)
            {
                Models.Skill mappedSkill = new Models.Skill();
                
                mappedSkill.Id = skill.Id;
                mappedSkill.Name = skill.Name;

                mapped.Add(mappedSkill);
            }

            return new Response<List<Models.Skill>>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Skill> Insert(Models.NameBaseDto nameBase){
            Skill skill = new Skill();
            skill.Name = nameBase.Name;
            Skill? insertedSkill = unitOfWork.skillRepository.Insert(skill);

            unitOfWork.Complete();
            
            if(insertedSkill == null)
                return new Response<Models.Skill>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            Models.Skill mapped = new Models.Skill {
                Id = insertedSkill.Id,
                Name = insertedSkill.Name
            };
            
            return new Response<Models.Skill>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.Created);
        }

        public Response<Models.Skill> GetById(int id) 
        {
            Skill? entity = unitOfWork.skillRepository.GetById(id);
            if(entity == null)
                return new Response<Models.Skill>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            Models.Skill mapped = new Models.Skill();
            mapped.Id = entity.Id;
            mapped.Name = entity.Name;
            return new Response<Models.Skill>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Skill> SoftDelete(int id)
        {
            if(unitOfWork.skillRepository.GetById(id) is null)
                return new Response<Models.Skill>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            unitOfWork.skillRepository.SoftDelete(id);
            unitOfWork.skillRepository.Save();

            return new Response<Models.Skill>(ResponseMessages.OK.ToDescription(), null, (int)ResponseCodes.OK);
        }
    }
}