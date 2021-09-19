using EventManager.Repo.Interfaces;
using System;
using System.Threading.Tasks;

namespace EventManager.Repo.Services
{
    public class StatusService : IStatusService
    {
        private readonly IEmployeeService _employeeService;
        private readonly IOfferSevice _offerSevice;

        public StatusService(IOfferSevice offerSevice, IEmployeeService employeeService)
        {
            _offerSevice = offerSevice;
            _employeeService = employeeService;
        }

        public Task<bool> RegisterToOffer(int employeeId, int offerId)
        {
            // TODO: Status not in Offer
            throw new NotImplementedException();
        }
    }
}
