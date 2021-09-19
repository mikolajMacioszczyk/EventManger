using System.Collections.Generic;

namespace EventManager.Domain.Models
{
    public class EventManagement
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public ICollection<EmployeeGroup> EmplyeeGroups { get; set; }
    }
}
