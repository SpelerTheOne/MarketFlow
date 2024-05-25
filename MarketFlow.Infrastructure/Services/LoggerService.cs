using MarketFlow.Infrastructure.Enums;
using MarketFlow.Infrastructure.Services.Interfaces;

namespace MarketFlow.Infrastructure.Services
{
    public class LoggerService : ILoggerService
    {
        public void Log(Exception exception, LogLevel logLevel)
        {
            //throw new NotImplementedException();
        }

        public void Log(LogLevel logLevel, string text)
        {
            //throw new NotImplementedException();
        }
    }
}
