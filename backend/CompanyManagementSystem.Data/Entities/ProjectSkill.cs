using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Models
{
    public class ProjectSkill : TimeStamp
    {
        public ProjectSkill()
        {
            this.DeveloperSkills = new HashSet<ProjectDeveloperSkill>();
        }
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjectSkills")]
        public Project Project { get; set; }
        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        [InverseProperty("ProjectSkills")]
        public Skill Skill { get; set; }
        public ICollection<ProjectDeveloperSkill> DeveloperSkills { get; set; }
    }
}