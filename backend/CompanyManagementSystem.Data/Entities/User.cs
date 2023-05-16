using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Models
{
    public class User : TimeStamp
    {
        public User()
        {
            this.UserSkills = new HashSet<UserSkill>();
            this.UserBenefits = new HashSet<UserBenefit>();
            this.UserLanguages = new HashSet<UserLanguage>();
            this.UserReligiousHolidays = new HashSet<UserReligiousHoliday>();
            this.RequestedVacationRequests = new HashSet<VacationRequest>();
            this.ProcessedVacationRequests = new HashSet<VacationRequest>();
            this.ProjectDevelopers = new HashSet<ProjectDeveloper>();
            this.CreatedNotes = new HashSet<Note>();
            this.AssignedNotes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Users")]
        public UserRole UserRole { get; set; }

        public int WorkingPositionId { get; set; }
        [ForeignKey("WorkingPositionId")]
        [InverseProperty("Users")]
        public UserWorkingPosition UserWorkingPosition { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("Users")]
        public UserStatus UserStatus { get; set; }
        
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime EmploymentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public int FreeDaysThisYear {get; set; }
        public int FreeDaysLastYear {get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }
        public ICollection<UserBenefit> UserBenefits { get; set; }
        public ICollection<UserLanguage> UserLanguages { get; set; }
        public ICollection<UserReligiousHoliday> UserReligiousHolidays { get; set; }
        public ICollection<VacationRequest> RequestedVacationRequests { get; set; }
        public ICollection<VacationRequest> ProcessedVacationRequests { get; set; }
        public ICollection<ProjectDeveloper> ProjectDevelopers { get; set; }
        public ICollection<Note> CreatedNotes { get; set; }
        public ICollection<Note> AssignedNotes { get; set; }

    }
}