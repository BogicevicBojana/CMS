using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.UserReligiousHolidays
{
    #pragma warning disable
    public class UserReligiousHolidayRepository : GenericRepository<UserReligiousHoliday>, IUserReligiousHolidayRepository
    {
        private readonly ApplicationDbContext context;

        public UserReligiousHolidayRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public void AddUserReligiousHoliday(UserReligiousHoliday userReligiousHoliday)
        {
            var user = context.Users                          
            .Include(user => user.UserReligiousHolidays)                  
            .Single(user => user.Id == userReligiousHoliday.UserId);
 
            var religiousHoliday = context.ReligiousHolidays                   
            .Single(religiousHoliday => religiousHoliday.Id == userReligiousHoliday.ReligiousHolidayId);
 
            user.UserReligiousHolidays.Add(new UserReligiousHoliday
            {
                ReligiousHoliday = religiousHoliday,
                User = user,
            });
            context.SaveChanges();
        }
        
        public void RemoveUserReligiousHoliday(UserReligiousHoliday userReligiousHolidayEntry)
        {
            var user = context.Users                          
            .Include(user => user.UserReligiousHolidays)                  
            .Single(user => user.Id == userReligiousHolidayEntry.UserId);
 
            var religiousHoliday = context.ReligiousHolidays                   
            .Single(religiousHoliday => religiousHoliday.Id == userReligiousHolidayEntry.ReligiousHolidayId);

            UserReligiousHoliday userReligiousHoliday = context.UserReligiousHolidays.Where(userReligiousHoliday => userReligiousHoliday.UserId == user.Id && userReligiousHoliday.ReligiousHolidayId == religiousHoliday.Id)
                                                                        .FirstOrDefault();
            context.UserReligiousHolidays.Attach(userReligiousHoliday);
            context.Entry(userReligiousHoliday).State = EntityState.Deleted;
            user.UserReligiousHolidays.Remove(userReligiousHoliday);
            context.SaveChanges();
        }
    }
}