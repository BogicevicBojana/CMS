using System;
using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
    public class WorkingPosition : NameBaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

    }
}