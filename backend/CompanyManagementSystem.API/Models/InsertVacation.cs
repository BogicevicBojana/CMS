using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class InsertVacation 
    {
        [JsonPropertyName("start_date")]
        public DateOnly StartDate {get;set;}
        [JsonPropertyName("end_date")]
        public DateOnly EndDate {get;set;}
        [JsonPropertyName("user_id")]
        public int UserId {get; set;}
    }
}