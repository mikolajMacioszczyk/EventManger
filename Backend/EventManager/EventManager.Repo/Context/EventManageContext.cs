using EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

// dotnet ef migrations add MigrationName --project ../EventManager.Repo

namespace EventManager.Repo.Context
{
    public class EventManageContext : DbContext
    {
        public EventManageContext(DbContextOptions<EventManageContext> options): base(options)
        {}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<EmployeeGroup> EmployeeGroups { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventManagement> EventManagements { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
    }
}
