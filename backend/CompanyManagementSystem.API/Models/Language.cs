using System;
using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class Language : NameBaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

    }
}