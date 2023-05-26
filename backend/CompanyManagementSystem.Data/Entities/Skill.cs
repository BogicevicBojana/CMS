
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Entities
{
    #pragma warning disable
    public class Skill : TimeStamp
    {
        //Constructor with Enum type parameter
        public Skill(Skills skills)
        {
            this.Id = (int)skills;
            this.Name = skills.ToDescription();
            this.DateCreated = DateTime.UtcNow;
            this.DateModified = DateTime.UtcNow;
        }

        public Skill()
        {
            this.UserSkills = new HashSet<UserSkill>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator Skill(Skills @enum) => new Skill(@enum);

        public static implicit operator Skills(Skill skill) => (Skills)skill.Id;
    }
}