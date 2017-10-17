using CurrencyConverter.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Services.Providers
{
    public static class PictureStorageProvider
    {
        public static void AddPictureStorage(this IServiceCollection services)
        {
            services.AddTransient<IPictureStorage, PictureStorage>();
        }
    }
}
