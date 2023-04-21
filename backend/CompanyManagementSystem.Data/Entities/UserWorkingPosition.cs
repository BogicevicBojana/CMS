using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Models
{
    public class UserWorkingPosition : TimeStamp
    {
        public UserWorkingPosition(WorkingPositions positions)
        {
            this.Id = (int)positions;
            this.Name = positions.ToDescription();
            this.DateCreated = DateTime.UtcNow;
            this.DateModified = DateTime.UtcNow;
        }
        public UserWorkingPosition()
        {
            this.Users = new HashSet<User>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator UserWorkingPosition(WorkingPositions @enum) => new UserWorkingPosition(@enum);

        public static implicit operator WorkingPositions(UserWorkingPosition position) => (WorkingPositions)position.Id;
    }
}