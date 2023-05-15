
 

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Data.Entities
{
    public class VacationRequest : TimeStamp
    {
        public int Id { get; set; }
        public int RequestedById { get; set; }
        public User RequestedBy { get; set; }

        public int VacationId { get; set; }
        public Vacation Vacation { get; set; }

        public int RequestStatusId { get; set; }
        
        [ForeignKey("RequestStatusId")]
        public RequestStatus RequestStatus { get; set; }

        public int? ProcessedById { get; set; }

        [ForeignKey("ProcessedById")]
        public User ProcessedBy { get; set; }

    }
}