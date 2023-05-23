using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class User : BaseUser
    {
        [JsonPropertyName("date_of_birth")]
        public DateOnly? DateOfBirth { get; set; }
        [JsonPropertyName("employment_date")]
        public DateOnly? EmploymentDate { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("mobile_number")]
        public string MobileNumber { get; set; }
        [JsonPropertyName("skills")]
        public List<Skill> Skills { get; set; }
        [JsonPropertyName("benefits")]
        public List<Benefit> Benefits { get; set; }
        [JsonPropertyName("languages")]
        public List<Language> Languages {get; set; }
        [JsonPropertyName("working_position")]
        public WorkingPosition WorkingPosition { get; set; }
        [JsonPropertyName("role")]
        public Role Role { get; set; }
        [JsonPropertyName("user_status")]
        public UserStatus UserStatus { get; set; }
        [JsonPropertyName("vacations")]
        public List<BaseVacationRequest> Vacations { get; set; }
        [JsonPropertyName("religious_holidays")]
        public List<ReligiousHoliday> ReligiousHolidays { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("free_days")]
        public int FreeDays { get; set; }
        [JsonPropertyName("full_name")]
        public string FullName {get;set;}

    }
}