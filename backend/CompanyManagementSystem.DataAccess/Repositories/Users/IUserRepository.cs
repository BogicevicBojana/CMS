using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User? GetUserById(long id);
        IEnumerable<User>? GetAllUsers();
        User? GetUserByEmail(string email);
        IEnumerable<User>? GetAllNonDeletedUsers();
    }
}