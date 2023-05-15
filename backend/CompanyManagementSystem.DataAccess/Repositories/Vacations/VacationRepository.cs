using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.Vacations
{
    public class VacationRepository : GenericRepository<Vacation>, IVacationRepository
    {
        private readonly ApplicationDbContext context;

        public VacationRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}