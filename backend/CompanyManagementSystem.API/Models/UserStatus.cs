using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class UserStatus : NameBaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}