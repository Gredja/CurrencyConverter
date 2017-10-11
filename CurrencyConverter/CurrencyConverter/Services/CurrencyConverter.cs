using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using CurrencyConverter.Services.Interfaces;
using Newtonsoft.Json;

namespace CurrencyConverter.Services
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public string GetCurrencyConversion(decimal amount, string fromCurrency, string toCurrency)
        {
            var request = GetConvertRequest(fromCurrency, toCurrency);
            var response = ExecuteRequest(request);
            var exchangeRate = decimal.Parse(response, CultureInfo.InvariantCulture);

            return (amount * exchangeRate).ToString("N3");
        }

        public List<string> GetAllCurrencies()
        {
            var response = ExecuteRequest("https://openexchangerates.org/api/currencies.json");

            return JsonConvert.DeserializeObject<IDictionary<string, string>>(response).Keys.ToList();
        }

        private string ExecuteRequest(string request)
        {
            using (var wc = new WebClient())
            {
                return wc.DownloadString(request);
            }
        }

        private string GetConvertRequest(string fromCurrency, string toCurrency)
        {
            return string.Format("http://finance.yahoo.com/d/quotes.csv?s={0}{1}=X&f=l1", fromCurrency, toCurrency);
        }

    }
}
