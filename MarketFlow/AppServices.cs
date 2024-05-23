using MarketFlow.Infrastructure.Logger;
using MarketFlow.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace MarketFlow
{
    public static class AppServices
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Add logging
            services.AddSingleton<ILogger, ConsoleLogger>();

            // Add other services here
            services.AddTransient<MainWindow>();
            services.AddTransient<MainWindowViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
