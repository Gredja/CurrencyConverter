using System.Timers;
using CurrencyConverter.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.ViewComponents
{
    public class CurrentTimeTimer : ViewComponent
    {
        private ITimeService _timeService;

        public CurrentTimeTimer(ITimeService timeService)
        {
            _timeService = timeService;

            var timer = new Timer(1);
            timer.Elapsed += Elapsed;
            timer.Start();
        }

        private void Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke();
        }

        public string Invoke()
        {
            return _timeService?.GetTime();
        }
    }
}
