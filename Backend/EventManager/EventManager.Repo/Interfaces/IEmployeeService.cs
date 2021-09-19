using System.Threading.Tasks;
using EventManager.Domain.Models;

namespace EventManager.Repo.Interfaces
{
    public interface IEmployeeService
    {
        Task<Emplyee> GetEmployeeById(int id);
    }
}
