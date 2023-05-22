using CompanyManagementSystem.API.Response;
using CompanyManagementSystem.API.Utils;
using  CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;
using CompanyManagementSystem.DataAccess;

namespace CompanyManagementSystem.API.Services.Users
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public User? GetUserByEmail(string email)
        {
            return unitOfWork.userRepository.GetUserByEmail(email);
        }

        public Response<Models.User> GetById(int id) {
            User user = unitOfWork.userRepository.GetUserById(id);

            if(user is null)
                return new Response<Models.User>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);

            Models.User mapped = Mappers.MapToUserDto(user);
            return new Response<Models.User>(ResponseMessages.OK.ToDescription(), mapped, (int)ResponseCodes.OK);
        }

        public Response<List<Models.User>> GetAllUsers()
        {
            var users = unitOfWork.userRepository.GetAllUsers();
            if(users.Count() == 0 || users is null)
                new Response<Models.User>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);

            List<Models.User> mappedList = new List<Models.User>();
            foreach (var item in users)
            {
                var mapped = Mappers.MapToUserDto(item);
                mappedList.Add(mapped);
            }
            return new Response<List<Models.User>>(ResponseMessages.OK.ToDescription(), mappedList, (int)ResponseCodes.OK);
        }

        public Response<List<Models.User>> GetAllNonDeletedUsers()
        {
            var users = unitOfWork.userRepository.GetAllNonDeletedUsers();
            if(users.Count() == 0 || users is null)
                new Response<Models.User>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);

            List<Models.User> mappedList = new List<Models.User>();
            foreach (var item in users)
            {
                var mapped = Mappers.MapToUserDto(item);
                mappedList.Add(mapped);
            }
            return new Response<List<Models.User>>(ResponseMessages.OK.ToDescription(), mappedList, (int)ResponseCodes.OK);
        }

        public Response<Models.User> SoftDelete(int id)
        {
            if(unitOfWork.userRepository.GetUserById(id) is null)
                return new Response<Models.User>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);
            unitOfWork.userRepository.SoftDelete(id);
            unitOfWork.userRepository.GetUserById(id).StatusId = (int)UserStatuses.Inactive;
            unitOfWork.userRepository.Save();

            return new Response<Models.User>(ResponseMessages.OK.ToDescription(), null, (int)ResponseCodes.OK);
        }

        public Response<Models.User> Insert(Models.UserRegister user)
        {
            if(unitOfWork.userRepository.GetUserByEmail(user.Email) is not null)
                return  new Response<Models.User>(ResponseMessages.UserAlreadyExists.ToDescription(), null, (int)ResponseCodes.BadRequest);

            User? insertedUser = unitOfWork.userRepository.Insert(Mappers.MapToUserEntity(user));
            unitOfWork.Complete();

            if(insertedUser == null)
                return new Response<Models.User>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            
            return new Response<Models.User>(ResponseMessages.OK.ToDescription(), Mappers.MapToUserDto(unitOfWork.userRepository.GetUserById(insertedUser.Id)), (int)ResponseCodes.Created);
            
        }

        public Response<Models.User> Update(Models.UserUpdate user)
        {
            if(unitOfWork.userRepository.GetUserById(user.Id) is null)
                return  new Response<Models.User>(ResponseMessages.DoesNotExist.ToDescription(), null, (int)ResponseCodes.BadRequest);

            try {
                unitOfWork.userRepository.Update(Mappers.MapToUserEntity(user));
                unitOfWork.Complete();
            } catch(NullReferenceException)
            {
                return new Response<Models.User>(ResponseMessages.SomethingWentWrong.ToDescription(), null, (int)ResponseCodes.BadRequest);
            }
            
            return new Response<Models.User>(ResponseMessages.OK.ToDescription(), Mappers.MapToUserDto(unitOfWork.userRepository.GetUserById(user.Id)), (int)ResponseCodes.Created);
            
        }

        public Response<List<Models.Benefit>> UpdateUserBenefit(Models.UserBenefit userBenefitDTO, bool selected)
        {
            var benefitToUpdate = Mappers.MapToUserBenefitEntity(userBenefitDTO);
            if (selected)
            {
                unitOfWork.userBenefitRepository.AddUserBenefit(benefitToUpdate);
                if (benefitToUpdate.BenefitId == (int)Data.Enums.Benefits.ParentsDayOff)
                {
                    User user = unitOfWork.userRepository.GetUserById(benefitToUpdate.UserId);
                    user.FreeDays += 1;
                    unitOfWork.userRepository.Update(user);
                    unitOfWork.userRepository.Save();
                }
            }
            else
            {
                unitOfWork.userBenefitRepository.RemoveUserBenefit(benefitToUpdate);
                if (benefitToUpdate.BenefitId == (int)Data.Enums.Benefits.ParentsDayOff)
                {
                    User user = unitOfWork.userRepository.GetUserById(benefitToUpdate.UserId);
                    user.FreeDays -= 1;
                    unitOfWork.userRepository.Update(user);
                    unitOfWork.userRepository.Save();
                }
            }
            var benefits = unitOfWork.benefitRepository.GetAllWithUser(userBenefitDTO.UserId);
            var benefitsDTO = new List<Models.Benefit>();
            foreach (var item in benefits)
            {
                benefitsDTO.Add(Mappers.MapToBenefitDto(item));
            }

            return new Response<List<Models.Benefit>>(ResponseMessages.OK.ToDescription(), benefitsDTO, (int)ResponseCodes.OK);
        }
    }
}