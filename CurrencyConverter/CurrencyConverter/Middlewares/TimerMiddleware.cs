using CurrencyConverter.Services;
using Microsoft.AspNetCore.Http;

namespace CurrencyConverter.Middlewares
{
    public class TimerMiddleware : ITimeService
    {
        private readonly RequestDelegate _next;
        private readonly TimeService _timeService;

        public TimerMiddleware(RequestDelegate next, TimeService timeService)
        {
            _next = next;
            _timeService = timeService;
        }

        public string GetTime()
        {
            //TODO
            return null;
        }
    }
}
