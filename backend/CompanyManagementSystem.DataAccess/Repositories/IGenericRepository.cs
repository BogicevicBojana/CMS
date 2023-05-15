namespace CompanyManagementSystem.DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T Insert(T entity);
        void Update(T entity);
        void SoftDelete(int id);
        void Save();
    }
}