using CompanyManagementSystem.API.Response;

namespace CompanyManagementSystem.API.Services.Vacations
{
    public interface IVacationService
    {
        Response<List<Models.Vacation>> GetAll();
        Response<Models.Vacation> Insert(Models.InsertVacation vacation);
        Response<string> RemoveVacation(int id);
    }
}