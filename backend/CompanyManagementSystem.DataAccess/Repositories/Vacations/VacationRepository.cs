using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.Vacations
{
    #pragma warning disable
    public class VacationRepository : GenericRepository<Vacation>, IVacationRepository
    {
        private readonly ApplicationDbContext context;

        public VacationRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public IEnumerable<Vacation> GetAll()
        {
            return context.Vacations.Include(vacation => vacation.User).ToList();

        }
        public Vacation? GetById(int id)
        {
            return context.Vacations.Include(vacation => vacation.User).ToList().Where(vacation => vacation.Id == id).FirstOrDefault();
        }

        public IEnumerable<Vacation> GetByUserId(int userId)
        {
            return context.Vacations.Include(vacation => vacation.User).ToList().Where(vacation => vacation.UserId == userId).ToList();
        }

        public void RemoveVacation(Vacation vacationEntry)
        {
            var user = context.Users                          
            .Include(user => user.Vacations)                  
            .Single(user => user.Id == vacationEntry.UserId);

            var vacation = context.Vacations.Where(vacation => vacation.Id == vacationEntry.Id).FirstOrDefault();

            context.Vacations.Attach(vacation);
            context.Entry(vacation).State = EntityState.Deleted;
            user.Vacations.Remove(vacation);
            context.SaveChanges();
        }
    }
}