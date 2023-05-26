using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories.Roles
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly ApplicationDbContext context;

        public RoleRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public Role? GetById(long id)
        {
            return context.Roles.Where(role => role.Id == id).SingleOrDefault();
        }
    }
}