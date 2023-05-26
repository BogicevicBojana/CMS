using System;
using Microsoft.AspNetCore.Authorization;
using CompanyManagementSystem.Data.Enums;

namespace CompanyManagementSystem.API.Utils.Auth
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
        private Roles[] _roles;
        public AuthorizeRolesAttribute(params Roles[] roles)
        {
            _roles = roles;
        }
    }
}