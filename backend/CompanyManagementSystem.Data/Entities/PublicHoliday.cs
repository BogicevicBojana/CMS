using System;
using System.ComponentModel.DataAnnotations; 

namespace CompanyManagementSystem.Data.Entities
{
    public class PublicHoliday 
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}