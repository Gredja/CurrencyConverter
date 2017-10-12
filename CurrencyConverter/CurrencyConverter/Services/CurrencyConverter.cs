using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using CurrencyConverter.Models;
using CurrencyConverter.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter.Services
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public decimal GetCurrencyConversion(decimal amount, string fromCurrency, string toCurrency)
        {
            var request = GetConvertRequest(fromCurrency, toCurrency);
            var response = ExecuteRequest(request);
            JObject data = (JObject)JsonConvert.DeserializeObject(response);
            var rate = (decimal) data.Children().First().Children().Values().First();

            return amount *  rate;
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
            return string.Format("http://free.currencyconverterapi.com/api/v3/convert?q={0}_{1}&compact=y", fromCurrency, toCurrency);
        }

    }
}
