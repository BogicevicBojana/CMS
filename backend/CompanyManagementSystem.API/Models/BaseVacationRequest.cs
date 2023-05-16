using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class BaseVacationRequest 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("vacation")]
        public Vacation Vacation { get; set; }
        [JsonPropertyName("request_status")]
        public RequestStatus RequestStatus { get; set; }
    }
}