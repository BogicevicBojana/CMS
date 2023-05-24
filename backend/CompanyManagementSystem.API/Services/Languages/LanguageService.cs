using CompanyManagementSystem.DataAccess;
using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.API.Services.Languages
{
    public class LanguageService : ILanguageService
    {
        private IUnitOfWork unitOfWork;

        public LanguageService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public Response<List<Models.Language>> GetAllLanguages()
        {
            var languages = unitOfWork.languageRepository.GetAllLanguages();

            List<Models.Language> mapped = new List<Models.Language>();
            foreach (var language in languages)
            {
                Models.Language mappedLanguage = new Models.Language();
                
                mappedLanguage.Id = language.Id;
                mappedLanguage.Name = language.Name;

                mapped.Add(mappedLanguage);
            }

            return new Response<List<Models.Language>>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Language> Insert(Models.NameBaseDto nameBase){
            Language language = new Language();
            language.Name = nameBase.Name;
            Language? insertedLanguage = unitOfWork.languageRepository.Insert(language);

            unitOfWork.Complete();

            if(insertedLanguage == null)
                return new Response<Models.Language>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            Models.Language mapped = new Models.Language {
                Id = insertedLanguage.Id,
                Name = insertedLanguage.Name
            };
            
            return new Response<Models.Language>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.Created);
        }

        public Response<Models.Language> GetById(int id) 
        {
            Language? entity = unitOfWork.languageRepository.GetById(id);
            if(entity == null)
                return new Response<Models.Language>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            Models.Language mapped = new Models.Language();
            mapped.Id = entity.Id;
            mapped.Name = entity.Name;
            return new Response<Models.Language>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Language> SoftDelete(int id)
        {
            if(unitOfWork.languageRepository.GetById(id) is null)
                return new Response<Models.Language>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            unitOfWork.languageRepository.SoftDelete(id);
            unitOfWork.languageRepository.Save();

            return new Response<Models.Language>(ResponseMessages.OK.ToDescription(), null, (int)ResponseCodes.OK);
        }
    }
}