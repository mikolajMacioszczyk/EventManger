using EventManager.Domain.Enums;
using System;

namespace EventManager.Domain.Models
{
    public class EmployeeGroup
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public PositionType PositionType { get; set; }
        public DateTime GatheringTime { get; set; }
        public Address GatheringAddress { get; set; }
        public double salary { get; set; }
        public double Hours { get; set; }
    }
}
