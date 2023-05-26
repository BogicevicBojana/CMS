using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Utils.Auth
{
    #pragma warning disable CS8618
    public class AuthenticateRequest
    {
        [JsonPropertyName("id_token")]
        [Required]
        public string IdToken { get; set; }
    }
}