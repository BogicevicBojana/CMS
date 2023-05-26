using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.Skills
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        private readonly ApplicationDbContext context;

        public SkillRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return context.Skills.Where(skill => !skill.IsDeleted).ToList();
        }

        public Skill? GetById(int id)
        {
            return context.Skills.Where(skill => !skill.IsDeleted && skill.Id == id).SingleOrDefault();
        }
    }
}