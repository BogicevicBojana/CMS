using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.UserSkills
{
    public class UserSkillRepository : GenericRepository<UserSkill>, IUserSkillRepository
    {
        private readonly ApplicationDbContext context;

        public UserSkillRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public UserSkill? GetByUserAndSkillId(int userId, int skillId)
        {
            return context.UserSkills.Where(userSkill => userSkill.UserId == userId 
            && userSkill.SkillId == skillId).SingleOrDefault();
        }
    }
}