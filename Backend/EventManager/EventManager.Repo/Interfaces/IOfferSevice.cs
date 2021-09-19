using EventManager.Domain.Enums;
using EventManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventManager.Repo.Interfaces
{
    public interface IOfferSevice
    {
        Task<IEnumerable<JobOffer>> GetAllOffers(PositionType positionType);
        Task<JobOffer> GetOfferById(int id);
        Task<bool> AddOffer(JobOffer offer);
        Task<bool> UpdateOffer(int id, JobOffer offer);
        Task<bool> DeleteOffer(int id);
    }
}
