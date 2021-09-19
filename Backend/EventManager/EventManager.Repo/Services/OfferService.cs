using EventManager.Domain.Enums;
using EventManager.Domain.Models;
using EventManager.Repo.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Repo.Services
{
    public class OfferService : IOfferSevice
    {
        // Mock
        private static readonly List<Event> Events = new List<Event>()
        {
            new Event(){Id = 1, Name = "Koncert Sanah"},
            new Event(){Id = 2, Name = "Kabaret Młodych Panów"},
        };
        private static readonly List<JobOffer> Offers = new List<JobOffer>()
        {
            new JobOffer(){Id = 1, PositionType = PositionType.BegginerInformationService, Hour = 2, Status = OfferStatus.New, Salary = 20, Event = Events[0] },
            new JobOffer(){Id = 2, PositionType = PositionType.BegginerInformationService, Hour = 5, Status = OfferStatus.New, Salary = 18, Event = Events[1] },
            new JobOffer(){Id = 3, PositionType = PositionType.ExperiencedInformationService, Hour = 6, Status = OfferStatus.New, Salary = 25, Event = Events[0] },
            new JobOffer(){Id = 4, PositionType = PositionType.Manager, Hour = 2, Status = OfferStatus.New, Salary = 30, Event = Events[0] },
            new JobOffer(){Id = 5, PositionType = PositionType.Security, Hour = 6, Status = OfferStatus.New, Salary = 20, Event = Events[1] }
        };

        public async Task<IEnumerable<JobOffer>> GetAllOffers(PositionType positionType)
        {
            return Offers.Where(o => o.PositionType == positionType);
        }

        public async Task<JobOffer> GetOfferById(int id)
        {
            return Offers.FirstOrDefault(o => o.Id == id);
        }

        public async Task<bool> AddOffer(JobOffer offer)
        {
            Offers.Add(offer);
            offer.Id = Offers.Select(o => o.Id).Max() + 1;
            return true;
        }

        public async Task<bool> UpdateOffer(int id, JobOffer offer)
        {
            var offerFromDb = await GetOfferById(id);
            if (offerFromDb == null)
            {
                return false;
            }

            await DeleteOffer(id);
            
            offer.Id = id;
            Offers.Add(offer);
            
            return true;
        }

        public async Task<bool> DeleteOffer(int id)
        {
            var offerFromDb = await GetOfferById(id);

            if (offerFromDb == null)
            {
                return false;
            }

            Offers.Remove(offerFromDb);
            return true;
        }
    }
}
