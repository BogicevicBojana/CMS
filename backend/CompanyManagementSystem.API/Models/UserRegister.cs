using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class UserRegister
    {
        [JsonPropertyName("first_name")]
        public string FirstName {get; set;}
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("employment_date")]
        public DateOnly EmploymentDate { get; set; }
        [JsonPropertyName("working_position_id")]
        public int WorkingPositionId { get; set; }
        [JsonPropertyName("role_id")]
        public int RoleId { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}