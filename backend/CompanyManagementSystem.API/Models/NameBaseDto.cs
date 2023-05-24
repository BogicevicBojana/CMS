using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    #pragma warning disable
    public class NameBaseDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}