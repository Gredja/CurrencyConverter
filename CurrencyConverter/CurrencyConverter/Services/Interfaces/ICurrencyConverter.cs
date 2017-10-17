using System.Collections.Generic;

namespace CurrencyConverter.Services.Interfaces
{
    public interface ICurrencyConverter
    {
        decimal GetCurrencyConversion(decimal amount, string fromCurrency, string toCurrency);

        List<string> GetAllCurrencies();
    }
}
