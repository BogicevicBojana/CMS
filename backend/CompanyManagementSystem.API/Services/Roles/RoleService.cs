using CompanyManagementSystem.DataAccess;

namespace CompanyManagementSystem.API.Services.Roles
{
    #pragma warning disable CS8602
    public class RoleService : IRoleService
    {
        private IUnitOfWork unitOfWork;
        public RoleService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public string? GetRoleNameById(long id)
        {
            return unitOfWork.roleRepository.GetById(id) is not null ? unitOfWork.roleRepository.GetById(id).Name : null;
        }
    }
}