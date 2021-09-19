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
        public ICollection<JobOffer> Offers { get; set; }
    }
}
