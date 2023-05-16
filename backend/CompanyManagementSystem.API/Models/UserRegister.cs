using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class UserRegister
    {
        [JsonPropertyName("first_name")]
        public string FirstName {get; set;}
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("date_of_birth")]
        public DateOnly? DateOfBirth { get; set; }
        [JsonPropertyName("employment_date")]
        public DateOnly EmploymentDate { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("mobile_number")]
        public string MobileNumber { get; set; }
        [JsonPropertyName("working_position_id")]
        public int WorkingPositionId { get; set; }
        [JsonPropertyName("role_id")]
        public int RoleId { get; set; }
        [JsonPropertyName("user_status_id")]
        public int UserStatusId { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}