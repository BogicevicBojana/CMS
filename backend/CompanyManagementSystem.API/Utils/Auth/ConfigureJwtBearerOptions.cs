using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CompanyManagementSystem.API.Utils.Auth
{
    #pragma warning disable CS8604
    public class ConfigureJwtBearerOptions : IConfigureNamedOptions<JwtBearerOptions>
    {
        private readonly IConfiguration configuration;

        public ConfigureJwtBearerOptions(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }
        public void Configure(string? name, JwtBearerOptions options)
        {
            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(Convert.FromBase64String(configuration["JwtPublicKey"]), out _);

            options.IncludeErrorDetails = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = true,
                ValidIssuer = "CompanyManagementSystem",
                ValidateAudience = true,
                ValidAudience = "cmsApi",
                CryptoProviderFactory = new CryptoProviderFactory()
                {
                    CacheSignatureProviders = false
                }
            };
        }

        public void Configure(JwtBearerOptions options)
        {
            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(Convert.FromBase64String(configuration["JwtPublicKey"]), out _);

            options.IncludeErrorDetails = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = true,
                ValidIssuer = "CompanyManagementSystem",
                ValidateAudience = true,
                ValidAudience = "cmsApi",
                CryptoProviderFactory = new CryptoProviderFactory()
                {
                    CacheSignatureProviders = false
                }
            };
        }
    }
}