using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyManagementSystem.Data.Entities
{
    public class UserReligiousHoliday : TimeStamp
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ReligiousHolidayId { get; set; }
        public ReligiousHoliday ReligiousHoliday { get; set; }
    }
}