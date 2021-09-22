using System.Threading.Tasks;

namespace EventManager.Repo.Interfaces
{
    public interface IStatusService
    {
        Task<bool> RegisterToOffer(int employeeId, int offerId);
    }
}
