using EventManager.Domain.Enums;

namespace EventManager.Domain.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public PositionType PositionType { get; set; }
        public Event Event { get; set; }
        public double Salary { get; set; }
        public double Hour { get; set; }

        public void Update(JobOffer offer)
        {
            PositionType = offer.PositionType;
            Event = offer.Event;
            Salary = offer.Salary;
            Hour = offer.Hour;
        }
    }
}
