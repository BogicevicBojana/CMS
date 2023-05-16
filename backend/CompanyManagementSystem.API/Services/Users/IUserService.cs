using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.API.Services.Users
{
    public interface IUserService
    {
        User? GetUserByEmail(string email);
        Response<Models.User> GetById(int id);
        Response<List<Models.User>> GetAllUsers();
        Response<Models.User> SoftDelete(int id);
        Response<Models.User> Insert(Models.UserRegister user);
    }
}