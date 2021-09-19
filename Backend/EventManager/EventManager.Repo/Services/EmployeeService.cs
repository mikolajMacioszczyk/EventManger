using EventManager.Domain.Models;
using EventManager.Repo.Interfaces;
using System;
using System.Threading.Tasks;

namespace EventManager.Repo.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<Employee> GetEmployeeById(int id)
        {
            // TODO: DBcontext
            throw new NotImplementedException();
        }
    }
}
