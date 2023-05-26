using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Entities
{
    #pragma warning disable
    public class User : TimeStamp
    {
        public User()
        {
            this.UserSkills = new HashSet<UserSkill>();
            this.UserBenefits = new HashSet<UserBenefit>();
            this.UserLanguages = new HashSet<UserLanguage>();
            this.UserReligiousHolidays = new HashSet<UserReligiousHoliday>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Users")]
        public Role Role { get; set; }

        public int WorkingPositionId { get; set; }
        [ForeignKey("WorkingPositionId")]
        [InverseProperty("Users")]
        public WorkingPosition WorkingPosition { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("Users")]
        public UserStatus UserStatus { get; set; }
        
        [Required]
        public string Email { get; set; }
        [Required]
        public DateOnly EmploymentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? MobileNumber { get; set; }
        public bool IsDeleted { get; set; }
        public int FreeDays {get; set;}

        public ICollection<UserSkill> UserSkills { get; set; }
        public ICollection<UserBenefit> UserBenefits { get; set; }
        public ICollection<UserLanguage> UserLanguages { get; set; }
        public ICollection<UserReligiousHoliday> UserReligiousHolidays { get; set; }
        public ICollection<Vacation> Vacations { get; set; }

    }
}