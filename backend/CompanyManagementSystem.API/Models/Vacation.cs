namespace CompanyManagementSystem.API.Models
{
    public class Vacation 
    {
        public int Id {get; set;}
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}