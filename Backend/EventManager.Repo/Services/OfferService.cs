using EventManager.Domain.Enums;
using EventManager.Domain.Models;
using EventManager.Repo.Context;
using EventManager.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Repo.Services
{
    public class OfferService : IOfferSevice
    {
        private readonly EventManageContext _context;

        public OfferService(EventManageContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobOffer>> GetAllOffers(PositionType positionType)
        {
            return await _context.JobOffers.Where(o => o.PositionType == positionType).ToListAsync();
        }

        public async Task<JobOffer> GetOfferById(int id)
        {
            return await _context.JobOffers.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<JobOffer> AddOffer(JobOffer offer)
        {
            await _context.JobOffers.AddAsync(offer);
            await _context.SaveChangesAsync();

            return offer;
        }

        public async Task<bool> UpdateOffer(int id, JobOffer offer)
        {
            var offerFromDb = await GetOfferById(id);
            if (offerFromDb == null)
            {
                return false;
            }

            offerFromDb.Update(offer);
            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<bool> DeleteOffer(int id)
        {
            var offerFromDb = await GetOfferById(id);

            if (offerFromDb == null)
            {
                return false;
            }

            _context.JobOffers.Remove(offerFromDb);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
