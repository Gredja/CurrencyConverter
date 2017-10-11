using System.Globalization;
using System.Net;
using CurrencyConverter.Services.Interfaces;

namespace CurrencyConverter.Services
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public string GetCurrencyConversion(decimal amount, string fromCurrency, string toCurrency)
        {
            var request = GetRequest(fromCurrency, toCurrency);

            using (var wc = new WebClient())
            {
                var response = wc.DownloadString(request);
                var exchangeRate = decimal.Parse(response, CultureInfo.InvariantCulture);

                return (amount * exchangeRate).ToString("N3");
            }
        }

        private string GetRequest(string fromCurrency, string toCurrency)
        {
            return string.Format("http://finance.yahoo.com/d/quotes.csv?s={0}{1}=X&f=l1", fromCurrency, toCurrency);
        }
    }
}
