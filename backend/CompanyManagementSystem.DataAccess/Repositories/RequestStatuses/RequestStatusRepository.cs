using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.RequestStatuses
{
    public class RequestStatusRepository : GenericRepository<RequestStatus>, IRequestStatusRepository
    {
        private readonly ApplicationDbContext context;

        public RequestStatusRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}