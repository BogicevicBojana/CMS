using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Entities
{
    public class RequestStatus
    {
        //Constructor with Enum type parameter
        public RequestStatus(RequestStatuses statuses)
        {
            this.Id = (int)statuses;
            this.Name = statuses.ToDescription();
        }
        public RequestStatus()
        {
            this.VacationRequests = new HashSet<VacationRequest>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // * Navigation Properties
        public ICollection<VacationRequest> VacationRequests { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator RequestStatus(RequestStatuses @enum) => new RequestStatus(@enum);

        public static implicit operator RequestStatuses(RequestStatus requestStatus) => (RequestStatuses)requestStatus.Id;
    }
}