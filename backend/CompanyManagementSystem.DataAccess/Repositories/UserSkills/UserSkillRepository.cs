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
    }
}