using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.VacationRequests
{
    public class VacationRequestRepository : GenericRepository<VacationRequest>, IVacationRequestRepository
    {
        private readonly ApplicationDbContext context;

        public VacationRequestRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}