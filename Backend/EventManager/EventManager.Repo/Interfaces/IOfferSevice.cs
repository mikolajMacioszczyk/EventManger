using EventManager.Domain.Enums;
using EventManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventManager.Repo.Interfaces
{
    public interface IOfferSevice
    {
        Task<IEnumerable<JobOffer>> GetAllOffers(PositionType positionType);
    }
}
