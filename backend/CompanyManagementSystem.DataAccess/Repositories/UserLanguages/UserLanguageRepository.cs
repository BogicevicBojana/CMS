using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.UserLanguages
{
    public class UserLanguageRepository : GenericRepository<UserLanguage>, IUserLanguageRepository
    {
        private readonly ApplicationDbContext context;

        public UserLanguageRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public UserLanguage? GetByUserAndLanguageId(int userId, int languageId)
        {
            return context.UserLanguages.Where(userLanguage => userLanguage.UserId == userId 
            && userLanguage.LanguageId == languageId).SingleOrDefault();
        }

        public void AddUserLanguage(UserLanguage userLanguage)
        {
            var user = context.Users                          
            .Include(user => user.UserLanguages)                  
            .Single(user => user.Id == userLanguage.UserId);
 
            var language = context.Languages                   
            .Single(language => language.Id == userLanguage.LanguageId);
 
            user.UserLanguages.Add(new UserLanguage
            {
                Language = language,
                User = user,
            });
            context.SaveChanges();
        }
        
        public void RemoveUserLanguage(UserLanguage userLanguageEntry)
        {
            var user = context.Users                          
            .Include(user => user.UserLanguages)                  
            .Single(user => user.Id == userLanguageEntry.UserId);
 
            var language = context.Languages                   
            .Single(language => language.Id == userLanguageEntry.LanguageId);

            UserLanguage userLanguage = context.UserLanguages.Where(userLanguage => userLanguage.UserId == user.Id && userLanguage.LanguageId == language.Id)
                                                                        .FirstOrDefault();
            context.UserLanguages.Attach(userLanguage);
            context.Entry(userLanguage).State = EntityState.Deleted;
            user.UserLanguages.Remove(userLanguage);
            context.SaveChanges();
        }
    }
}