using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.UserLanguages
{
    public class UserLanguageRepository : GenericRepository<UserLanguage>, IUserLanguageRepository
    {
        private readonly ApplicationDbContext context;

        public UserLanguageRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}