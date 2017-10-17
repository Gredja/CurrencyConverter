using CurrencyConverter.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Services.Providers
{
    public static class CurrencyConverterProvider
    {
        public static void AddCurrencyConverter(this IServiceCollection services)
        {
            services.AddTransient<ICurrencyConverter, CurrencyConverter>();
        }
    }
}
