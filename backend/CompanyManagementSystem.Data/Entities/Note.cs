using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Models
{
    public class Note : TimeStamp
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public int AssignedToId { get; set; }
        public User AssignedTo { get; set; }
    }
}