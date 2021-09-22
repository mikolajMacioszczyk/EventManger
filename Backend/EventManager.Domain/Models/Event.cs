using System;

namespace EventManager.Domain.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public Address EventAddress { get; set; }
        public string Poster { get; set; }
    }
}
