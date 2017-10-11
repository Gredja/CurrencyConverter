namespace CurrencyConverter.Services.Interfaces
{
    public interface ICurrencyConverter
    {
        string GetCurrencyConversion(decimal amount, string fromCurrency, string toCurrency);

        string GetRequiest(decimal amount, string fromCurrency, string toCurrency));
    }
}
