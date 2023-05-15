using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.WorkingPositions
{
    public interface IWorkingPositionRepository : IGenericRepository<WorkingPosition>
    {
        IEnumerable<WorkingPosition> GetAllPositions();
        WorkingPosition? GetById(int id);
    }
}