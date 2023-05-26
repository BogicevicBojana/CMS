using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.WorkingPositions
{
    public class WorkingPositionRepository : GenericRepository<WorkingPosition>, IWorkingPositionRepository
    {
        private readonly ApplicationDbContext context;

        public WorkingPositionRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public IEnumerable<WorkingPosition> GetAllPositions()
        {
            var positions = context.WorkingPositions.Where(position => !position.IsDeleted).ToList();
            return positions;
        }
        public WorkingPosition? GetById(int id)
        {
            return context.WorkingPositions.Where(position => !position.IsDeleted && position.Id == id).SingleOrDefault();
        }
    }
}