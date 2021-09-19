using EventManager.Domain.Models;
using EventManager.Repo.Context;
using EventManager.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EventManager.Repo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EventManageContext _context;

        public EmployeeService(EventManageContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees.Include(e => e.OfferStatuses).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
