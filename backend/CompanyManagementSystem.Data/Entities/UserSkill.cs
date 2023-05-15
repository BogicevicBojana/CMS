using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

using System;

namespace CompanyManagementSystem.Data.Entities
{
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