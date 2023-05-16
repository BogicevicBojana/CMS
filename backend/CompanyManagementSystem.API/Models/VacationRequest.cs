using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class VacationRequest : BaseVacationRequest
    {
        [JsonPropertyName("user")]
        public BaseUser User { get; set; }
    }
}