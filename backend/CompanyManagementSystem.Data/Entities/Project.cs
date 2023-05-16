using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace CompanyManagementSystem.Data.Models
{
    public class Project : TimeStamp
    {
        public Project()
        {
            this.ProjectDevelopers = new HashSet<ProjectDeveloper>();
            this.ProjectSkills = new HashSet<ProjectSkill>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public bool IsCompanys { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProjectDeveloper> ProjectDevelopers{ get; set; }
        public ICollection<ProjectSkill> ProjectSkills { get; set; }
    } 
}