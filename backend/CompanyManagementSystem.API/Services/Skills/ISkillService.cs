using CompanyManagementSystem.API.Response;

namespace CompanyManagementSystem.API.Services.Skills
{
    public interface ISkillService
    {
        Response<List<Models.Skill>> GetAllSkills();
        Response<Models.Skill> Insert(Models.NameBaseDto nameBase);
        Response<Models.Skill> GetById(int id);
        Response<Models.Skill> SoftDelete(int id);
    }
}