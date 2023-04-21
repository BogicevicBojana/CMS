using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Models
{
    public class ProjectDeveloperSkill : TimeStamp
    {
        public int Id { get; set; }
        public int ProjectDeveloperId { get; set; }

        [ForeignKey("ProjectDeveloperId")]
        public ProjectDeveloper ProjectDeveloper { get; set; }
        public int ProjectSkillId { get; set; }

        [ForeignKey("ProjectSkillId")]
        public ProjectSkill ProjectSkill { get; set; }
    }
}