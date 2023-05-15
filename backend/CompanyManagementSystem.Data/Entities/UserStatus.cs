using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Entities
{
    public class UserStatus
    {
        public UserStatus(UserStatuses statuses)
        {
            this.Id = (int)statuses;
            this.Name = statuses.ToDescription();
        }
        public UserStatus()
        {
            this.Users = new HashSet<User>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // * Navigation Properties
        public ICollection<User> Users { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator UserStatus(UserStatuses @enum) => new UserStatus(@enum);

        public static implicit operator UserStatuses(UserStatus userStatus) => (UserStatuses)userStatus.Id;
    }
}