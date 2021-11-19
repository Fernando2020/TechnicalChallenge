using Microsoft.Extensions.DependencyInjection;
using TechnicalChallenge.Core.Entities;
using TechnicalChallenge.Manager;
using TechnicalChallenge.Manager.Interfaces;

namespace TechnicalChallenge.Console
{
    class Program
    {
        private static IDividerManager _dividerManager;
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _dividerManager = serviceProvider.GetService<IDividerManager>();

            var divider = new Divider { Number = 1 };
            var response = _dividerManager.GetDividers(divider);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddManager();
        }
    }
}
