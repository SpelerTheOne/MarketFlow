using MarketFlow.Infrastructure.Enums;

namespace MarketFlow.Infrastructure.Services.Interfaces
{
    public interface ILoggerService
    {
        void Log(Exception exception, LogLevel logLevel);
        void Log(LogLevel logLevel, string text);
    }
}
