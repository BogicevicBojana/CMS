using System;
using System.Collections.Generic;
using CompanyManagementSystem.DataAccess;
using CompanyManagementSystem.Data.Entities;
using Models = CompanyManagementSystem.API.Models;
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