using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext context;

        public UserRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public User? GetUserById(long id)
        {
             var users = context.Users.Include(user => user.Role)
                                        .Include(user => user.WorkingPosition)
                                        .Include(user => user.UserBenefits)
                                            .ThenInclude(userBenefit => userBenefit.Benefit)
                                        .Include(user => user.UserSkills)
                                            .ThenInclude(userSkill => userSkill.Skill)
                                        .Include(user => user.UserLanguages)
                                            .ThenInclude(userLanguage => userLanguage.Language)
                                        .Include(user => user.UserReligiousHolidays)
                                            .ThenInclude(userHoliday => userHoliday.ReligiousHoliday)
                                        .Include(user => user.UserStatus)
                                        .Include(user => user.Vacations);

            return users.Where(user => user.Id == id).SingleOrDefault();
        }

        public IEnumerable<User>? GetAllUsers()
        {
             var users = context.Users.Include(user => user.Role)
                                        .Include(user => user.WorkingPosition)
                                        .Include(user => user.UserBenefits)
                                            .ThenInclude(userBenefit => userBenefit.Benefit)
                                        .Include(user => user.UserSkills)
                                            .ThenInclude(userSkill => userSkill.Skill)
                                        .Include(user => user.UserLanguages)
                                            .ThenInclude(userLanguage => userLanguage.Language)
                                        .Include(user => user.UserReligiousHolidays)
                                            .ThenInclude(userHoliday => userHoliday.ReligiousHoliday)
                                        .Include(user => user.UserStatus)
                                        .Include(user => user.Vacations);
                                        
            return users.ToList();
        }

        public IEnumerable<User>? GetAllNonDeletedUsers()
        {
             var users = context.Users.Include(user => user.Role)
                                        .Include(user => user.WorkingPosition)
                                        .Include(user => user.UserBenefits)
                                            .ThenInclude(userBenefit => userBenefit.Benefit)
                                        .Include(user => user.UserSkills)
                                            .ThenInclude(userSkill => userSkill.Skill)
                                        .Include(user => user.UserLanguages)
                                            .ThenInclude(userLanguage => userLanguage.Language)
                                        .Include(user => user.UserReligiousHolidays)
                                            .ThenInclude(userHoliday => userHoliday.ReligiousHoliday)
                                        .Include(user => user.UserStatus)
                                        .Include(user => user.Vacations);
                                        
            return users.Where(user => !user.IsDeleted).ToList();
        }

        public User? GetUserByEmail(string email)
        {
             var users = context.Users.Include(user => user.Role)
                                        .Include(user => user.WorkingPosition)
                                        .Include(user => user.UserBenefits)
                                            .ThenInclude(userBenefit => userBenefit.Benefit)
                                        .Include(user => user.UserSkills)
                                            .ThenInclude(userSkill => userSkill.Skill)
                                        .Include(user => user.UserLanguages)
                                            .ThenInclude(userLanguage => userLanguage.Language)
                                        .Include(user => user.UserReligiousHolidays)
                                            .ThenInclude(userHoliday => userHoliday.ReligiousHoliday)
                                        .Include(user => user.UserStatus)
                                        .Include(user => user.Vacations);

            return users.Where(user => user.Email == email).SingleOrDefault();
        }
    }
}