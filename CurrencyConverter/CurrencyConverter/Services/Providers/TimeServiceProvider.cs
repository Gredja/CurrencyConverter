using CurrencyConverter.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Services.Providers
{
    public static class TimeServiceProvider
    {
        public static void AddTimeService(this IServiceCollection services)
        {
            services.AddTransient<ITimeService, TimeService>();
        }
    }
}
