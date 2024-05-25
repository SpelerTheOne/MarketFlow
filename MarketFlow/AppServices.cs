using MarketFlow.Client.ViewModels;
using MarketFlow.Client.Views;
using MarketFlow.Infrastructure.Logger;
using MarketFlow.Infrastructure.Services;
using MarketFlow.Infrastructure.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MarketFlow.Client
{
    public static class AppServices
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Add logging
            //services.AddSingleton<ILogger, ConsoleLogger>();

            // Add other services here
            services.AddTransient<MainWindow>();
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<ILogger, ConsoleLogger>();
            services.AddTransient<ILoggerService, LoggerService>();

            return services.BuildServiceProvider();
        }
    }
}
