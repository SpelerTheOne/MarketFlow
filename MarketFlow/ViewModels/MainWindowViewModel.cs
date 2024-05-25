using MarketFlow.Infrastructure.Logger;

namespace MarketFlow.Client.ViewModels
{
    public class MainWindowViewModel : IDisposable
    {
        private readonly ILogger _logger;
        private readonly IDisposable _cleanUp;

        public MainWindowViewModel(ILogger logger)
        {
            _logger = logger;

            //_logger.Log("MainWindow initialized");
            _logger = logger;
        }

        public void Dispose()
        {
            _cleanUp?.Dispose();
        }
    }
}
