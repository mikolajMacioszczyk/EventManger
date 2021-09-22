using EventManager.Domain.Enums;

namespace EventManager.Domain.Models
{
    public class JobOfferStatus
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public JobOffer JobOffer { get; set; }
        public OfferStatus Status { get; set; }
    }
}
