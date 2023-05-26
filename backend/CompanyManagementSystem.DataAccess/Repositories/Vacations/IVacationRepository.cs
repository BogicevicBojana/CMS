using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.Vacations
{
    public interface IVacationRepository : IGenericRepository<Vacation>
    {
        IEnumerable<Vacation> GetAll();
        Vacation? GetById(int id);
        IEnumerable<Vacation> GetByUserId(int userId);
        void RemoveVacation(Vacation vacationEntry);
    }
}