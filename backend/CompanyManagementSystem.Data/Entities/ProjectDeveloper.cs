using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Models
{
    public class ProjectDeveloper : TimeStamp
    {
        public ProjectDeveloper()
        {
            this.DeveloperSkills= new HashSet<ProjectDeveloperSkill>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ProjectDevelopers")]
        public User User { get; set; }
        
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjectDevelopers")]
        public Project Project { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string Description { get; set; }

        public ICollection<ProjectDeveloperSkill> DeveloperSkills { get; set; }
    }
}