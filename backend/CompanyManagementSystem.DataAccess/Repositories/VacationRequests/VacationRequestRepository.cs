using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.VacationRequests
{
    public class VacationRequestRepository : GenericRepository<VacationRequest>, IVacationRequestRepository
    {
        private readonly ApplicationDbContext context;

        public VacationRequestRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public IEnumerable<VacationRequest>? GetAll()
        {
            return context.VacationRequests.Include(request => request.RequestedBy)
                                            .Include(request => request.Vacation)
                                            .Include(request => request.RequestStatus).ToList();
        }
    }
}