using System;

namespace MyShopCore.Web.API.Brokers.Loggings
{
    public class LoggingBroker : ILoggingBroker
    {

        private readonly ILogger<LoggingBroker> _logger;
        public void LogCritical(Exception exception)
        {
            this._logger.LogCritical(exception, exception.Message);
        }

        public void LogDebug(string message)
        {
            this._logger.LogDebug(message);

        }

        public void LogError(Exception exception)
        {
            this._logger.LogError(exception, exception.Message);

        }

        public void LogInformation(Exception exception)
        {
            this._logger.LogInformation(exception, exception.Message);
        }

        public void LogTrace(string message)
        {
            this._logger.LogTrace(message);
        }

        public void LogWarning(Exception exception)
        {
            this._logger.LogWarning(exception, exception.Message);

        }
    }
}
