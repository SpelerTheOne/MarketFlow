using MarketFlow.Client.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace MarketFlow.Client.Helper
{
    public static class ViewModelLocator
    {
        public static readonly bool IsInDesignMode = DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject());
        private static IServiceProvider _provider;

        public static MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return _provider.GetRequiredService<MainWindowViewModel>();
            }
        }

        internal static void SetProvider(IServiceProvider provider) => _provider = provider;
    }
}
