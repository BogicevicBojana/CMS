
using CompanyManagementSystem.DataAccess;
using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.API.Services.Benefits
{
    public class BenefitService : IBenefitService
    {
        private IUnitOfWork unitOfWork;

        public BenefitService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public Response<List<Models.Benefit>> GetAllBenefits()
        {
            var benefits = unitOfWork.benefitRepository.GetAllBenefits();

            List<Models.Benefit> mapped = new List<Models.Benefit>();
            foreach (var benefit in benefits)
            {
                Models.Benefit mappedBenefit = new Models.Benefit();
                
                mappedBenefit.Id = benefit.Id;
                mappedBenefit.Name = benefit.Name;

                mapped.Add(mappedBenefit);
            }

            return new Response<List<Models.Benefit>>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Benefit> Insert(Models.NameBaseDto nameBase){
            Benefit benefit = new Benefit();
            benefit.Name = nameBase.Name;
            Benefit? insertedBenefit = unitOfWork.benefitRepository.Insert(benefit);

            unitOfWork.Complete();


            if(insertedBenefit == null)
                return new Response<Models.Benefit>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            Models.Benefit mapped = new Models.Benefit {
                Id = insertedBenefit.Id,
                Name = insertedBenefit.Name
            };

            return new Response<Models.Benefit>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.Created);
        }

        public Response<Models.Benefit> GetById(int id) 
        {
            Benefit? entity = unitOfWork.benefitRepository.GetById(id);
            if(entity == null)
                return new Response<Models.Benefit>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            Models.Benefit mapped = new Models.Benefit();
            mapped.Id = entity.Id;
            mapped.Name = entity.Name;
            return new Response<Models.Benefit>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Benefit> SoftDelete(int id)
        {
            if(unitOfWork.benefitRepository.GetById(id) is null)
                return new Response<Models.Benefit>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            unitOfWork.benefitRepository.SoftDelete(id);
            unitOfWork.benefitRepository.Save();

            return new Response<Models.Benefit>(ResponseMessages.OK.ToDescription(), null, (int)ResponseCodes.OK);
        }
    }
}