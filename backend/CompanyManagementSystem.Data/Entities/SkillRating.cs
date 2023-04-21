using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Models
{
    public class SkillRating
    {
        //Constructor with Enum type parameter
        public SkillRating(Ratings ratings)
        {
            this.Id = (int)ratings;
            this.Name = ratings.ToString();
            this.Description = ratings.ToDescription();
        }
        public SkillRating()
        {
            this.UserSkills = new HashSet<UserSkill>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        // * Navigation Properties
        public ICollection<UserSkill> UserSkills { get; set; }

        public static implicit operator SkillRating(Ratings @enum) => new SkillRating(@enum);

        public static implicit operator Ratings(SkillRating rating) => (Ratings)rating.Id;
    }
}