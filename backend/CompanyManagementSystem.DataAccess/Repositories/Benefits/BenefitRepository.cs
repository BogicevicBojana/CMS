using CompanyManagementSystem.Data;
using CompanyManagementSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.Benefits
{
        public class BenefitRepository : GenericRepository<Benefit>, IBenefitRepository
    {
        private readonly ApplicationDbContext context;

        public BenefitRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public IEnumerable<Benefit> GetAllBenefits()
        {
            return context.Benefits.Where(benefit => !benefit.IsDeleted).ToList();
        }

        public Benefit? GetById(int id)
        {
            return context.Benefits.Where(benefit => !benefit.IsDeleted && benefit.Id == id).SingleOrDefault();
        }

        public IEnumerable<Benefit> GetAllWithUser(int id)
        {
            var userBenefits = context.Benefits.Include(benefit => benefit.UserBenefits)
                                                .ThenInclude(userBenefit => userBenefit.User);

            var benefits = userBenefits.Where(benefit => 
                                        benefit.UserBenefits.Any(userBenefit => userBenefit.User.Id == id))
                                        .ToList();
            return benefits;
        }
    }
}