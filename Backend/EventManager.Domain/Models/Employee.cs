using EventManager.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EventManager.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public PositionType PositionType { get; set; }
        public ICollection<JobOfferStatus> OfferStatuses { get; set; }

        public void AddStatus(JobOfferStatus status)
        {
            if (OfferStatuses is null)
            {
                OfferStatuses = new List<JobOfferStatus>() { status };
            }
            else
            {
                OfferStatuses.Add(status);
            }
        }
    }
}
