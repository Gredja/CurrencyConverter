using CurrencyConverter.Services.Interfaces;

namespace CurrencyConverter.Services
{
    public class TimeService : ITimeService
    {
        public string GetTime() => System.DateTime.Now.ToString("hh:mm:ss");
    }
}
