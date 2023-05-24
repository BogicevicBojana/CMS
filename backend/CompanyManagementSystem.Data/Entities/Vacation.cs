using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Entities
{
    public class Vacation : TimeStamp
    {

        public int Id { get; set; }
        [Required]
        public DateOnly StartDate { get; set; }
        [Required]
        public DateOnly EndDate { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Vacations")]
        public User User {get;set;}
        public int UserId {get;set;}
    }
}