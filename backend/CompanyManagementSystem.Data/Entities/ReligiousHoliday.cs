using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace CompanyManagementSystem.Data.Entities
{
    public class ReligiousHoliday : TimeStamp
    {
        public ReligiousHoliday()
        {
            this.UserReligiousHolidays = new HashSet<UserReligiousHoliday>();
        }
        public int Id { get; set; }
        [Required]
        public DateOnly Date { get; set; }

        // * Navigation Properties
        public ICollection<UserReligiousHoliday> UserReligiousHolidays { get; set; }

    }
}