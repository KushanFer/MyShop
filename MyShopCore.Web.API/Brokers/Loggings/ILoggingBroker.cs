namespace MyShopCore.Web.API.Brokers.Loggings
{
    public interface ILoggingBroker
    {
        void LogInformation(Exception message);
        void LogDebug(string message);

        void LogTrace(string message);
        void LogWarning(Exception message);

        void LogError(Exception message);
        void LogCritical(Exception message);
    }
}
