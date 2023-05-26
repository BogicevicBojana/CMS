using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.PublicHolidays
{
    public class PublicHolidayRepository : GenericRepository<PublicHoliday>, IPublicHolidayRepository
    {
        private readonly ApplicationDbContext context;

        public PublicHolidayRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}