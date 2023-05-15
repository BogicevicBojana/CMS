using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Entities
{
    public class Role
    {
        //Constructor with Enum type parameter
        public Role(Roles roles)
        {
            this.Id = (int)roles;
            this.Name = roles.ToDescription();
        }

        public Role()
        {
            this.Users = new HashSet<User>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // * Navigation Properties
        public ICollection<User> Users { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator Role(Roles @enum) => new Role(@enum);

        public static implicit operator Roles(Role role) => (Roles)role.Id;
    }
}