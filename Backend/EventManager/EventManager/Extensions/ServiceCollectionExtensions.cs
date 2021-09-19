using EventManager.Repo.Context;
using EventManager.Repo.Interfaces;
using EventManager.Repo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventManager.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IOfferSevice, OfferService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EventManageContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
               x => x.MigrationsAssembly("EventManager.Repo")));
            return services;
        }
    }
}
