using CurrencyConverter.Services.Interfaces;
using CurrencyConverter.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyConverter _currencyConverter;

        public HomeController(ICurrencyConverter currencyConverter)
        {
            _currencyConverter = currencyConverter;
        }

        public IActionResult Index()
        {
            var model = new AllCurrrencyTypesViewModel { CurrencyTypes = _currencyConverter.GetAllCurrencies() };

            return View(model);
        }

        public IActionResult MyViewComponent()
        {
            return ViewComponent("CurrentTimeTimer");
        }

        public IActionResult Convert(AllCurrrencyTypesViewModel model)
        {
            return View("Index");
        }
    }
}
