using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class NameBaseDto
    {
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
    }
}