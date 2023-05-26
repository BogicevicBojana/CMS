using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.UserReligiousHolidays
{
    public interface IUserReligiousHolidayRepository : IGenericRepository<UserReligiousHoliday>
    {
        void AddUserReligiousHoliday(UserReligiousHoliday userReligiousHoliday);
        void RemoveUserReligiousHoliday(UserReligiousHoliday userReligiousHolidayEntry);
    }
}