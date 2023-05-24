using CompanyManagementSystem.API.Response;

namespace CompanyManagementSystem.API.Services.WorkingPositions
{
    public interface IWorkingPositionService
    {
        Response<List<Models.WorkingPosition>> GetAllPositions();
        Response<Models.WorkingPosition> Insert(Models.NameBaseDto nameBase);
        Response<Models.WorkingPosition> GetById(int id);

        Response<Models.WorkingPosition> SoftDelete(int id);
    }
}