using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.Languages
{
    public interface ILanguageRepository : IGenericRepository<Language>
    {
        IEnumerable<Language> GetAllLanguages();
        Language? GetById(int id);

    }
}