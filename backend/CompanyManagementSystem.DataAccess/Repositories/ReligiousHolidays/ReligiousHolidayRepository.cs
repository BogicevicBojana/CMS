using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.ReligiousHolidays
{
    public class ReligiousHolidayRepository : GenericRepository<ReligiousHoliday>, IReligiousHolidayRepository
    {
        private readonly ApplicationDbContext context;

        public ReligiousHolidayRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}