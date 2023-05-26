using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    #pragma warning disable
    public class BaseUser 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName {get; set;}
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("full_name")]
        public string FullName {get;set;}

    }
}