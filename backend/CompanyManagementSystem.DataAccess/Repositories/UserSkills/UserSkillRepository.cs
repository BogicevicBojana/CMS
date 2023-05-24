using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.UserSkills
{
    #pragma warning disable
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

        public void AddUserSkill(UserSkill userSkill)
        {
            var user = context.Users                          
            .Include(user => user.UserSkills)                  
            .Single(user => user.Id == userSkill.UserId);
 
            var skill = context.Skills                   
            .Single(skill => skill.Id == userSkill.SkillId);
 
            user.UserSkills.Add(new UserSkill
            {
                Skill = skill,
                User = user,
            });
            context.SaveChanges();
        }
        
        public void RemoveUserSkill(UserSkill userSkillEntry)
        {
            var user = context.Users                          
            .Include(user => user.UserSkills)                  
            .Single(user => user.Id == userSkillEntry.UserId);
 
            var skill = context.Skills                   
            .Single(skill => skill.Id == userSkillEntry.SkillId);

            UserSkill userSkill = context.UserSkills.Where(userSkill => userSkill.UserId == user.Id && userSkill.SkillId == skill.Id)
                                                                        .FirstOrDefault();
            context.UserSkills.Attach(userSkill);
            context.Entry(userSkill).State = EntityState.Deleted;
            user.UserSkills.Remove(userSkill);
            context.SaveChanges();
        }
    }
}