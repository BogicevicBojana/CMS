using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.UserBenefits
{
    public class UserBenefitRepository : GenericRepository<UserBenefit>, IUserBenefitRepository
    {
        private readonly ApplicationDbContext context;

        public UserBenefitRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}