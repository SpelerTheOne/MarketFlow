using MarketFlow.Infrastructure.Enums;
using MarketFlow.Infrastructure.Services.Interfaces;

namespace MarketFlow.Infrastructure.Logger
{
    /// <summary>
    /// A LoggerService proxy osztálya 
    /// a már meglévő installer implementáció bekötéséhez
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        public void AppendException(Exception exception)
            => AppendException(LogLevel.FatalError, exception);

        public void AppendException(LogLevel logLevel, Exception exception)
            => _service?.Log(exception, logLevel);

        public void AppendText(string text)
            => AppendText(LogLevel.Info, text);

        public void AppendText(LogLevel logLevel, string text)
            => _service?.Log(logLevel, text);

        readonly private ILoggerService _service;

        public ConsoleLogger(ILoggerService service)
        {

        }
    }
}
