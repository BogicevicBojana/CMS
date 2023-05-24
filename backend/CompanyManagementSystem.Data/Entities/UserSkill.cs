using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Entities
{
    #pragma warning disable
    public class UserSkill : TimeStamp
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserSkills")]
        public User User { get; set; }

        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        [InverseProperty("UserSkills")]
        public Skill Skill { get; set; }

    }
}