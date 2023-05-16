using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyManagementSystem.Data.Models
{
    public class UserLanguage : TimeStamp
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}