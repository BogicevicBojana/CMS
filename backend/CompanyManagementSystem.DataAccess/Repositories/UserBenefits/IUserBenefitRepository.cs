using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.UserBenefits
{
    public interface IUserBenefitRepository : IGenericRepository<UserBenefit>
    {
        UserBenefit? GetByUserAndBenefitId(int userId, int benefitId);

        void AddUserBenefit(UserBenefit userBenefit);

        void RemoveUserBenefit(UserBenefit userBenefitEntry);
    }
}