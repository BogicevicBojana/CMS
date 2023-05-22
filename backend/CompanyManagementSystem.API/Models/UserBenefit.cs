using System.Text.Json.Serialization;

namespace CompanyManagementSystem.API.Models
{
	public class UserBenefit
	{
		[JsonPropertyName("user_id")]
        public int UserId { get; set; }


        [JsonPropertyName("benefit_id")]
        public int BenefitId { get; set; }
	}
}