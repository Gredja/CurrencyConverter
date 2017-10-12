using CurrencyConverter.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    public class PicturesController : Controller
    {
       // [Route("Pictrures")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
