using CompanyManagementSystem.API.Response;

namespace CompanyManagementSystem.API.Services.Benefits
{
    public interface IBenefitService
    {
        Response<List<Models.Benefit>> GetAllBenefits();

        Response<Models.Benefit> Insert(Models.NameBaseDto nameBase);

        Response<Models.Benefit> GetById(int id);

        Response<Models.Benefit> SoftDelete(int id);
    }
}