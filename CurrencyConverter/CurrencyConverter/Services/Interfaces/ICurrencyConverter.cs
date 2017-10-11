using System.Collections.Generic;

namespace CurrencyConverter.Services.Interfaces
{
    public interface ICurrencyConverter
    {
        string GetCurrencyConversion(decimal amount, string fromCurrency, string toCurrency);

        List<string> GetAllCurrencies();
    }
}
