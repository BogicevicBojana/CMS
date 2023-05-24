using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.API.Utils;
using CompanyManagementSystem.Data.Extensions;
using CompanyManagementSystem.DataAccess;

namespace CompanyManagementSystem.API.Services.Vacations
{
    public class VacationService : IVacationService
    {
        private IUnitOfWork unitOfWork;

        public VacationService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public Response<List<Models.Vacation>> GetAll()
        {
            var vacations = unitOfWork.vacationRepository.GetAll().Where(vacation => vacation.EndDate.CompareTo(DateOnly.FromDateTime(DateTime.Now)) > 0);
            List<Models.Vacation> mapped = new List<Models.Vacation>();
            foreach (var item in vacations)
            {
                mapped.Add(Mappers.mapToVacationDTO(item));
            }
            return new Response<List<Models.Vacation>>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<Models.Vacation> Insert(Models.InsertVacation vacation)
        {
            if(vacation.StartDate.isNull() || vacation.EndDate.isNull() || vacation.UserId.isNull())
                return new Response<Models.Vacation>(ResponseMessages.ValidationError.ToDescription(), null, (int) ResponseCodes.BadRequest);
            if(vacation.StartDate.CompareTo(vacation.EndDate) > 0)
                return new Response<Models.Vacation>(ResponseMessages.StartDateError.ToDescription(), null, (int) ResponseCodes.BadRequest);

            var existingVacations = unitOfWork.vacationRepository.GetByUserId(vacation.UserId);
            // start date posle ili isto start date
            // end date pre ili jednak end date a posle start date

            //start date posle ili isto start date a pre end date
            // a end date posle ili jednak end date

            //startdate pre ili isto startdate
            //end date posle start date, i pre enddate

            //start date before start date
            // end date after end date
            if(existingVacations.Any(vac => vacation.StartDate.CompareTo(vac.StartDate) >= 0 && (vacation.EndDate.CompareTo(vac.EndDate) <= 0 && vacation.EndDate.CompareTo(vac.StartDate) >= 0))
            || (existingVacations.Any(vac => vacation.StartDate.CompareTo(vac.StartDate) >= 0 && vacation.StartDate.CompareTo(vac.EndDate) <= 0 && vacation.EndDate.CompareTo(vac.EndDate) >= 0))
            || (existingVacations.Any(vac => vacation.StartDate.CompareTo(vac.StartDate) <= 0 && (vacation.EndDate.CompareTo(vac.EndDate) <= 0 && vacation.EndDate.CompareTo(vac.StartDate) >= 0)))
            || (existingVacations.Any(vac => vacation.StartDate.CompareTo(vac.StartDate) <= 0 && (vacation.EndDate.CompareTo(vac.EndDate) >= 0))))
                return new Response<Models.Vacation>(ResponseMessages.VacationAlreadyExists.ToDescription(), null, (int) ResponseCodes.BadRequest);

            var vacationToInsert = Mappers.mapToVacationEntity(vacation);
            var insertedVacation = unitOfWork.vacationRepository.Insert(vacationToInsert);
            unitOfWork.Complete();
            var user = unitOfWork.userRepository.GetUserById(insertedVacation.UserId);
            user.FreeDays -= (int)(insertedVacation.EndDate.ToDateTime(TimeOnly.MinValue) - insertedVacation.StartDate.ToDateTime(TimeOnly.MinValue)).TotalDays;
            unitOfWork.userRepository.Update(user);
            unitOfWork.Complete();
            return new Response<Models.Vacation>(ResponseMessages.OK.ToDescription(), Mappers.mapToVacationDTO(unitOfWork.vacationRepository.GetById(insertedVacation.Id)), (int)ResponseCodes.Created);
        }

        public Response<string> RemoveVacation(int id)
        {
            var vacation = unitOfWork.vacationRepository.GetById(id);

            if(vacation is null)
                return new Response<string>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);

            unitOfWork.vacationRepository.RemoveVacation(vacation);

            if(unitOfWork.vacationRepository.GetById(id) is not null)
                return new Response<string>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            var user = unitOfWork.userRepository.GetUserById(vacation.UserId);
            user.FreeDays += (int)(vacation.EndDate.ToDateTime(TimeOnly.MinValue) - vacation.StartDate.ToDateTime(TimeOnly.MinValue)).TotalDays;
            unitOfWork.userRepository.Update(user);
            unitOfWork.Complete();

            return new Response<string>(ResponseMessages.OK.ToDescription(), null, (int)ResponseCodes.OK);
        }
    }
}