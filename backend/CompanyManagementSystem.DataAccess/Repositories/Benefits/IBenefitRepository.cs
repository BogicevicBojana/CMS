using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.Benefits
{
    public interface IBenefitRepository : IGenericRepository<Benefit>
    {
        IEnumerable<Benefit> GetAllBenefits();

        Benefit? GetById(int id);
    }
}