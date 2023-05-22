using CompanyManagementSystem.Data.Entities;

namespace CompanyManagementSystem.DataAccess.Repositories.UserLanguages
{
    public interface IUserLanguageRepository : IGenericRepository<UserLanguage>
    {
        UserLanguage? GetByUserAndLanguageId(int userId, int languageId);
    }
}