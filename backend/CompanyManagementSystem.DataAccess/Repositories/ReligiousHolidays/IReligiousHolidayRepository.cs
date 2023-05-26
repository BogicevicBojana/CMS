using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.ReligiousHolidays
{
    public interface IReligiousHolidayRepository : IGenericRepository<ReligiousHoliday>
    {
        ReligiousHoliday? GetByDate(DateOnly date);
    }
}