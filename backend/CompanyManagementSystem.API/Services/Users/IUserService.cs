using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.API.Services.Users
{
    public interface IUserService
    {
        User? GetUserByEmail(string email);
    }
}