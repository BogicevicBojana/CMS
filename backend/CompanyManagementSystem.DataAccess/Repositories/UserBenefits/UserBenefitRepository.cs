using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.DataAccess.Repositories.UserBenefits
{
    #pragma warning disable
    public class UserBenefitRepository : GenericRepository<UserBenefit>, IUserBenefitRepository
    {
        private readonly ApplicationDbContext context;

        public UserBenefitRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public UserBenefit? GetByUserAndBenefitId(int userId, int benefitId)
        {
            return context.UserBenefits.Where(userBenefit => userBenefit.UserId == userId 
            && userBenefit.BenefitId == benefitId).SingleOrDefault();
        }

        public void AddUserBenefit(UserBenefit userBenefit)
        {
            var user = context.Users                          
            .Include(user => user.UserBenefits)                  
            .Single(user => user.Id == userBenefit.UserId);
 
            var benefit = context.Benefits                   
            .Single(benefit => benefit.Id == userBenefit.BenefitId);
 
            user.UserBenefits.Add(new UserBenefit
            {
                Benefit = benefit,
                User = user,
            });
            context.SaveChanges();
        }
        
        public void RemoveUserBenefit(UserBenefit userBenefitEntry)
        {
            var user = context.Users                          
            .Include(user => user.UserBenefits)                  
            .Single(user => user.Id == userBenefitEntry.UserId);
 
            var benefit = context.Benefits                   
            .Single(benefit => benefit.Id == userBenefitEntry.BenefitId);

            UserBenefit userBenefit = context.UserBenefits.Where(userBenefit => userBenefit.UserId == user.Id && userBenefit.BenefitId == benefit.Id)
                                                                        .FirstOrDefault();
            context.UserBenefits.Attach(userBenefit);
            context.Entry(userBenefit).State = EntityState.Deleted;
            user.UserBenefits.Remove(userBenefit);
            context.SaveChanges();
        }
    }
}