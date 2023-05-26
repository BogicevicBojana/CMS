using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.Skills
{
    public interface ISkillRepository : IGenericRepository<Skill>
    {
        IEnumerable<Skill> GetAllSkills();
        Skill? GetById(int id);
    }
}