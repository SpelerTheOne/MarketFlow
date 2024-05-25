using MarketFlow.Infrastructure.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace MarketFlow.Infrastructure
{
    public class Program
    {
        public static void Main()
        {
            var services = new ServiceCollection();

            // Add logging
            services.AddSingleton<ILogger, ConsoleLogger>();

            services.BuildServiceProvider();
        }
    }
}
