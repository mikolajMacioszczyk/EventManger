using EventManager.Domain.Enums;

namespace EventManager.Domain.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public PositionType PositionType { get; set; }
        public double Salary { get; set; }
        public double Hour { get; set; }
        public OfferStatus Status { get; set; }
    }
}
