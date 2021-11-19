using Microsoft.Extensions.DependencyInjection;
using TechnicalChallenge.Manager.Implementations;
using TechnicalChallenge.Manager.Interfaces;

namespace TechnicalChallenge.Manager
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddManager(this IServiceCollection services)
        {
            services
                .AddScoped<IDividerManager, DividerManager>();

            return services;
        }
    }
}
