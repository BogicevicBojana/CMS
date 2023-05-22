using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class UserUpdate : UserRegister 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("free_days")]
        public int FreeDays {get;set;}
    }
}