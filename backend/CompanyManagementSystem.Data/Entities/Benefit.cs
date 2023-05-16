using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Models
{
    public class Benefit : TimeStamp
    {
        public Benefit(Benefits benefits)
        {
            this.Id = (int)benefits;
            this.Name = benefits.ToDescription();
            this.DateCreated = DateTime.UtcNow;
            this.DateModified = DateTime.UtcNow;
        }
        public Benefit()
        {
            this.UserBenefits = new HashSet<UserBenefit>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<UserBenefit> UserBenefits { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes
        
        public static implicit operator Benefit(Benefits @enum) => new Benefit(@enum);

        public static implicit operator Benefits(Benefit benefit) => (Benefits)benefit.Id;


    }
}