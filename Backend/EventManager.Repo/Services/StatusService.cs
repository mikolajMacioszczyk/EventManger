using EventManager.Domain.Models;
using EventManager.Repo.Context;
using EventManager.Repo.Interfaces;
using System.Threading.Tasks;

namespace EventManager.Repo.Services
{
    public class StatusService : IStatusService
    {
        private readonly IEmployeeService _employeeService;
        private readonly IOfferSevice _offerSevice;
        private readonly EventManageContext _context;

        public StatusService(IOfferSevice offerSevice, IEmployeeService employeeService, EventManageContext context)
        {
            _offerSevice = offerSevice;
            _employeeService = employeeService;
            _context = context;
        }

        public async Task<bool> RegisterToOffer(int employeeId, int offerId)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);
            var offer = await _offerSevice.GetOfferById(offerId);

            if (employee is null || offer is null)
            {
                return false;
            }

            JobOfferStatus status = new JobOfferStatus()
            {
                Employee = employee,
                JobOffer = offer,
                Status = Domain.Enums.OfferStatus.Registered
            };

            employee.AddStatus(status);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
