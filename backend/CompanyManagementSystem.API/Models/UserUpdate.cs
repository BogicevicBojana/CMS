using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class UserUpdate : UserRegister 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("date_of_birth")]
        public DateOnly? DateOfBirth { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("mobile_number")]
        public string MobileNumber { get; set; }
        [JsonPropertyName("skills")]
        public List<int> Skills { get; set; }
        [JsonPropertyName("languages")]
        public List<int> Languages {get; set; }
        [JsonPropertyName("religious_holidays")]
        public List<DateOnly> ReligiousHolidays { get; set; }
    }
}