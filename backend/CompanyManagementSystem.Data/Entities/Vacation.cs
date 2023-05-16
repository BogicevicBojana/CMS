using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyManagementSystem.Data.Entities
{
    public class Vacation : TimeStamp
    {
        public Vacation()
        {
            this.VacationRequests = new HashSet<VacationRequest>();
        }

        public int Id { get; set; }
        [Required]
        public DateOnly StartDate { get; set; }
        [Required]
        public DateOnly EndDate { get; set; }

        // * Navigation Properties
        public ICollection<VacationRequest> VacationRequests { get; set; }
    }
}