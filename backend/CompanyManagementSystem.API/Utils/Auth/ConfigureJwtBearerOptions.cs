using System.Security.Cryptography;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
            rsa.ImportRSAPublicKey(Convert.FromBase64String(PUBLIC_KEY), out _);

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
            rsa.ImportRSAPublicKey(Convert.FromBase64String(PRIVATE_KEY), out _);

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

        private const String PUBLIC_KEY = @"MIGJAoGBAJJZK3hPW/vLioF9KbitpTAqZalW/kkGBK7cvhfFY+VghW9mi5b9iQQfNzN1AFRvvtoTaGxtaGlDaaZC8X1hRCo5zXWxvvLQmqIQU8NtU3AWA6gUmSR7MKMdDpfdWF6vPERZ7T3oVL2s79hecNkeLiM/NnDuAroJrY8qjlQqa5YfAgMBAAE=";

        private const String PRIVATE_KEY = @"MIICXQIBAAKBgQCSWSt4T1v7y4qBfSm4raUwKmWpVv5JBgSu3L4XxWPlYIVvZouW
/YkEHzczdQBUb77aE2hsbWhpQ2mmQvF9YUQqOc11sb7y0JqiEFPDbVNwFgOoFJkk
ezCjHQ6X3VherzxEWe096FS9rO/YXnDZHi4jPzZw7gK6Ca2PKo5UKmuWHwIDAQAB
AoGAOcGHLkvjeVOyrbe/p2qgLooM5O+4GwmM/5WOT8NO0U9uWbCWllgoor/PATfD
kY8oOtg99cyX0DMSltMEiv6/721ITO65NkGSOaNUsNYXbS7ZaAW8px3LrgT4fHRh
/I4Xam6a4upBym7SWVEpBqhWwKuln9ZIKYUj/T7sBzvZtwECQQD0GImnEYhA3lvZ
D6B317/ZaqInQRWgyFFylW/x0z/ll0yXA6Nkd+8/YnqFYKzcnYlnX+pYOCE1S3k6
+PctEpQRAkEAmXxIsiswfhKhsmm1Gp4ZziadQU+yGuoQGHlM2bga6Ct+yeg+Dp/e
LeusNGrrO6bXbI+zhcvdqq2aYYQKUsb3LwJBAOeYpHpsiw+pKhIv3nv2q2N45jNC
cGflyElkehtC6RxISnX6ELwRg2FraX5FNJ35ptX7Tli3oOJ1IqgOck9EklECQFLj
pNrbqj+bzkls/wpV8be8cNaxtI0GdRTShWdbHuTdgIaH7uO1AKcqDIDucQVxEAwn
+xq5w4eGY8ZgKbcUjq8CQQDPz6zOTyrSpDvQWuFHx6y1awruCEAzjTfSh4j2Vqcl
yBwsG0v/NT/uq7q56ZvqhxC9YuTttEFpBQeGBKaBdof1";
    }
}