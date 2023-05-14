namespace MyShopCore.Web.API.Brokers.DateTimes
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime() => DateTime.UtcNow;
      
    }
}
