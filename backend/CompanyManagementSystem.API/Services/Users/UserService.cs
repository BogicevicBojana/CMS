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
    }
}