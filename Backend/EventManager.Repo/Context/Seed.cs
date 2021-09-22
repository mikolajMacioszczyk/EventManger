using EventManager.Domain.Enums;
using EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventManager.Repo.Context
{
    public class Seed
    {
        public static async Task SeedIfEmpty(EventManageContext context)
        {
            if (await context.Employees.AnyAsync())
            {
                return;
            }

            var addresses = new List<Address>()
            {
                new Address(){City = "Wrocław", Street = "Jagiellońska", Number = 2 },
                new Address(){City = "Opole", Street = "Kluczborska", Number = 123 },
            };

            var employess = new List<Employee>()
            {
                new Employee(){FirstName = "Alice", LastName = "Brown", BirthDate = System.DateTime.Now, PositionType = PositionType.BegginerInformationService},
                new Employee(){FirstName = "John", LastName = "Smith", BirthDate = System.DateTime.Now, PositionType = PositionType.ExperiencedInformationService},
                new Employee(){FirstName = "Cris", LastName = "Martin", BirthDate = System.DateTime.Now, PositionType = PositionType.Security},
                new Employee(){FirstName = "Jane", LastName = "McKeene", BirthDate = System.DateTime.Now, PositionType = PositionType.Manager},
            };

            var events = new List<Event>()
            {
                new Event(){Name = "Koncert Sanah", EventAddress= addresses[0], EventDate = System.DateTime.Now.AddDays(2)},
                new Event(){Name = "Kabaret Młodych Panów", EventAddress= addresses[1], EventDate = System.DateTime.Now.AddDays(5)},
            };

            var offers = new List<JobOffer>()
            {
                new JobOffer(){PositionType = PositionType.BegginerInformationService, Hour = 2, Salary = 20, Event = events[0] },
                new JobOffer(){PositionType = PositionType.BegginerInformationService, Hour = 5, Salary = 18, Event = events[1] },
                new JobOffer(){PositionType = PositionType.ExperiencedInformationService, Hour = 6, Salary = 25, Event = events[0] },
                new JobOffer(){PositionType = PositionType.Manager, Hour = 2, Salary = 30, Event = events[0] },
                new JobOffer(){PositionType = PositionType.Security, Hour = 6, Salary = 20, Event = events[1] }
            };

            var statuses = new List<JobOfferStatus>()
            {
                new JobOfferStatus(){Employee = employess[0], JobOffer = offers[1], Status = OfferStatus.Registered},
                new JobOfferStatus(){Employee = employess[1], JobOffer = offers[1], Status = OfferStatus.Accepted},
                new JobOfferStatus(){Employee = employess[1], JobOffer = offers[0], Status = OfferStatus.Canceled},
                new JobOfferStatus(){Employee = employess[1], JobOffer = offers[2], Status = OfferStatus.ReserveList},
                new JobOfferStatus(){Employee = employess[2], JobOffer = offers[3], Status = OfferStatus.Completed},
                new JobOfferStatus(){Employee = employess[3], JobOffer = offers[4], Status = OfferStatus.Undone},
            };

            await context.Addresses.AddRangeAsync(addresses);
            await context.Employees.AddRangeAsync(employess);
            await context.Events.AddRangeAsync(events);
            await context.JobOffers.AddRangeAsync(offers);
            await context.JobOfferStatuses.AddRangeAsync(statuses);

            await context.SaveChangesAsync();
        }
    }
}
