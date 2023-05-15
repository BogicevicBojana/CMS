using System;
using System.Collections.Generic;
using CompanyManagementSystem.DataAccess;
using CompanyManagementSystem.Data.Entities;
using Models = CompanyManagementSystem.API.Models;
using CompanyManagementSystem.API.Response;

namespace CompanyManagementSystem.API.Services.Languages
{
    public interface ILanguageService
    {
        Response<List<Models.Language>> GetAllLanguages();
        Response<Models.Language> Insert(Models.NameBaseDto nameBase);
        Response<Models.Language> GetById(int id);

        Response<Models.Language> SoftDelete(int id);
    }
}