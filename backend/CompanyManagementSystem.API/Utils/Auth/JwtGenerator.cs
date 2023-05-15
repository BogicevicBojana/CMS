using System.Security.Cryptography;
using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Collections.Generic;

namespace CompanyManagementSystem.API.Utils.Auth
{

    // * The signature is used to verify the message wasn't changed along the way, and, in the case of tokens signed with a private key, it can also verify that the sender of the JWT is who it says it is.
    // * ... for signed tokens this information (payload), though protected against tampering, is readable by anyone.
    // * JwtGenerator uses Asymmetric encryption. The main disadvantage of using Symmetric encryption is that anyone that has access to the key that the token was encrypted with, can also decrypt it.

    public class JwtGenerator
    {
        private readonly RsaSecurityKey key;

        public JwtGenerator(string privateKey)
        {
            RSA privateRSA = RSA.Create();
            byte[] signingKey = Convert.FromBase64String(privateKey);
            privateRSA.ImportRSAPrivateKey(signingKey, out _);
            key = new RsaSecurityKey(privateRSA);
        }

        // Generate new JWT with userId, userEmail and userRole as claims, generated token is signed using private key with Sha256 algorithm
        public string GenerateAuthToken(string userId, string userEmail, string userRole, string userPosition)
        {
            // create JwtSecuirtyTokenHandler instance to generate and convert tokens
            var tokenHandler = new JwtSecurityTokenHandler();

            // describe token payload and signature
            var tokenDescription = new SecurityTokenDescriptor
            {
                Audience = "cmsApi",
                Issuer = "CompanyManagementSystem",
                Subject = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, userId),
                    new Claim(ClaimTypes.Email, userEmail),
                    new Claim(ClaimTypes.Role, userRole),
                    new Claim("WorkingPosition", userPosition)
                }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.RsaSha256)
            };

            var jsonWebToken = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(jsonWebToken);
        }
    }
}