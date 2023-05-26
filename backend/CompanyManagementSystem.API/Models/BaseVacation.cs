namespace CompanyManagementSystem.API.Models
{
    public class BaseVacation 
    {
        public int Id {get; set;}
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}