using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data;
using Microsoft.EntityFrameworkCore;


namespace CompanyManagementSystem.DataAccess.Repositories.Languages
{
    public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
    {
        private readonly ApplicationDbContext context;

        public LanguageRepository(ApplicationDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public IEnumerable<Language> GetAllLanguages()
        {
            var languages = context.Languages.Where(language => !language.IsDeleted).ToList();
            return languages;
        }
        public Language? GetById(int id)
        {
            return context.Languages.Where(language => !language.IsDeleted && language.Id == id).SingleOrDefault();
        }
    }
}