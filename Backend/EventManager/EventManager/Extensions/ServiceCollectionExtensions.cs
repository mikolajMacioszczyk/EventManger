﻿using EventManager.Repo.Interfaces;
using EventManager.Repo.Services;
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
    }
}
