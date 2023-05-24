using CompanyManagementSystem.DataAccess;
using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.API.Services.WorkingPositions
{
    public class WorkingPositionService : IWorkingPositionService
    {
        private IUnitOfWork unitOfWork;

        public WorkingPositionService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public Response<List<Models.WorkingPosition>> GetAllPositions()
        {
            var positions = unitOfWork.workingPositionRepository.GetAllPositions();

            List<Models.WorkingPosition> mapped = new List<Models.WorkingPosition>();
            foreach (var position in positions)
            {
                Models.WorkingPosition mappedPosition = new Models.WorkingPosition();
                
                mappedPosition.Id = position.Id;
                mappedPosition.Name = position.Name;

                mapped.Add(mappedPosition);
            }

            return new Response<List<Models.WorkingPosition>>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.WorkingPosition> Insert(Models.NameBaseDto nameBase){
            WorkingPosition position = new WorkingPosition();
            position.Name = nameBase.Name;
            WorkingPosition? insertedPosition = unitOfWork.workingPositionRepository.Insert(position);

            unitOfWork.Complete();

            if(insertedPosition == null)
                return new Response<Models.WorkingPosition>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            Models.WorkingPosition mapped = new Models.WorkingPosition {
                Id = insertedPosition.Id,
                Name = insertedPosition.Name
            };
            
            return new Response<Models.WorkingPosition>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.Created);
        }

        public Response<Models.WorkingPosition> GetById(int id) 
        {
            WorkingPosition? entity = unitOfWork.workingPositionRepository.GetById(id);
            if(entity == null)
                return new Response<Models.WorkingPosition>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);;
            Models.WorkingPosition mapped = new Models.WorkingPosition();
            mapped.Id = entity.Id;
            mapped.Name = entity.Name;
            return new Response<Models.WorkingPosition>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.WorkingPosition> SoftDelete(int id)
        {
            if(unitOfWork.workingPositionRepository.GetById(id) is null)
                return new Response<Models.WorkingPosition>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            unitOfWork.workingPositionRepository.SoftDelete(id);
            unitOfWork.workingPositionRepository.Save();

            return new Response<Models.WorkingPosition>(ResponseMessages.OK.ToDescription(), null, (int)ResponseCodes.OK);
        }
    }
}