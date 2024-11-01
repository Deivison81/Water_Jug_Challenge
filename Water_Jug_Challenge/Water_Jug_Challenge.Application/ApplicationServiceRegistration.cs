using Microsoft.Extensions.DependencyInjection;
using Water_Jug_Challenge.Application.Contracts.Services;
using Water_Jug_Challenge.Application.Features.CapacityX;
using Water_Jug_Challenge.Application.Features.CapacityY;
using Water_Jug_Challenge.Application.Models;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services) 
        {
            services.AddScoped<IgenericServices<JugsX>, CapacityXHandler>();
            services.AddScoped<IgenericServices<JugsY>, CapacityYHandler>();
            services.AddScoped<ISteps, Stepsby>();

            return services;
        }
    }
}
