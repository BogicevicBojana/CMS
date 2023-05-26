using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class ReligiousHoliday
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("date")]
        public DateOnly Date { get; set; }
    }
}