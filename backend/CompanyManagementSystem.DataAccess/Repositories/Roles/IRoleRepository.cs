using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.Roles
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
         Role? GetById(long id);
    }
}