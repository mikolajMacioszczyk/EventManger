using EventManager.Repo.Interfaces;
using EventManager.Repo.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventManager.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services.AddScoped<IOfferSevice, OfferService>();
        }
    }
}
