using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.API.Services.Roles
{
    public interface IRoleService
    {
        string? GetRoleNameById(long id);
    }
}