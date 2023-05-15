using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.UserStatuses
{
    public class UserStatusRepository : GenericRepository<UserStatus>, IUserStatusRepository
    {
        private readonly ApplicationDbContext context;

        public UserStatusRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}