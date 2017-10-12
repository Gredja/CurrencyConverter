using CurrencyConverter.Services.Interfaces;
using CurrencyConverter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var model = new CurrrencyViewModel { CurrencyTypes = _currencyConverter.GetAllCurrencies() };

            return View(model);
        }

        public IActionResult MyViewComponent()
        {
            return ViewComponent("CurrentTimeTimer");
        }

        [HttpPost]
        public IActionResult Convert(CurrrencyViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewData["Result"] = _currencyConverter.GetCurrencyConversion(model.Amount, model.CurrencyFrom, model.CurrencyTo);
                return View("Convert");
            }

            return View("Index", model);
        }
    }
}
