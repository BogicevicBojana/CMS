namespace CompanyManagementSystem.Data.Entities
{
    #pragma warning disable
    public class UserBenefit : TimeStamp
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int BenefitId { get; set; }
        public Benefit Benefit { get; set; }
    }
}