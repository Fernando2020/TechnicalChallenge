using Microsoft.Extensions.DependencyInjection;
using System;
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

            BuildContent();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddManager();
        }

        private static void MessageWriteLine(string message = "")
        {
            System.Console.WriteLine(message);
        }

        private static void Message(string message = "")
        {
            System.Console.Write(message);
        }

        private static void BuildContent()
        {
            while (true)
            {
                try
                {
                    Message("Digite um número:");
                    var number = Convert.ToInt64(System.Console.ReadLine());

                    var divider = new Divider
                    {
                        Number = number
                    };

                    var response = _dividerManager.GetDividersAndPrimeNumbers(divider);

                    if (response.IsSuccess)
                    {
                        MessageWriteLine($"Número de Entrada: {divider.Number}");
                        MessageWriteLine($"Números divisores: {string.Join(" ", response.Dividers)}");
                        MessageWriteLine($"Divisores Primos: {string.Join(" ", response.PrimeNumbers)}");
                    }
                    else
                    {
                        MessageWriteLine(response.Error);
                    }
                }
                catch
                {
                    MessageWriteLine("Digite um número inteiro e válido.");
                }

                MessageWriteLine();
            }
        }
    }
}
