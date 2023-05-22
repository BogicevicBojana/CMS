using Microsoft.EntityFrameworkCore;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ApplicationDbContext context;
        protected DbSet<T> table;

        public GenericRepository(ApplicationDbContext _context)
        {
            this.context = _context;
            table = _context.Set<T>();
        }

        public void SoftDelete(int id)
        {
            var item = table.Find(id);
            if(item is not null)
            {
                var isDeletedProperty = item.GetType().GetProperty("IsDeleted");

                if (isDeletedProperty != null)
                    isDeletedProperty.SetValue(item, true);
                else
                    throw new InvalidOperationException("Soft delete is available only for entities with Deleted property.");
            }

        }

        public T Insert(T entity)
        {
            table.Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            var result = table.Find(entity.GetType().GetProperty("Id").GetValue(entity));
            if(result != null)
            {
                table.Entry(result).State = EntityState.Detached;
            }
            table.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }


        public void Save()
        {
            context.SaveChanges();
        }
    }
}