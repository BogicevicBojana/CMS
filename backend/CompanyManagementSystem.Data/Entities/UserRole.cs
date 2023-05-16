using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Models
{
    public class UserRole
    {
        //Constructor with Enum type parameter
        public UserRole(Roles roles)
        {
            this.Id = (int)roles;
            this.Name = roles.ToDescription();
        }

        public UserRole()
        {
            this.Users = new HashSet<User>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // * Navigation Properties
        public ICollection<User> Users { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator UserRole(Roles @enum) => new UserRole(@enum);

        public static implicit operator Roles(UserRole userRole) => (Roles)userRole.Id;
    }
}