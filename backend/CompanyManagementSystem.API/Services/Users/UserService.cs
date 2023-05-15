using  CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.DataAccess;

namespace CompanyManagementSystem.API.Services.Users
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public User? GetUserByEmail(string email)
        {
            return unitOfWork.userRepository.GetUserByEmail(email);
        }
    }
}