using MarketFlow.Client.Helper;
using MarketFlow.Client.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace MarketFlow.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ServiceProvider = AppServices.ConfigureServices();

            ViewModelLocator.SetProvider(ServiceProvider);

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

}
