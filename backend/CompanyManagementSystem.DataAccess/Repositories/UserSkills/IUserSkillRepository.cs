using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.UserSkills
{
    public interface IUserSkillRepository : IGenericRepository<UserSkill>
    {
        UserSkill? GetByUserAndSkillId(int userId, int skillId);
    }
}