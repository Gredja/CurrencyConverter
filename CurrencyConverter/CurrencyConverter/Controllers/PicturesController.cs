using CurrencyConverter.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    public class PicturesController : Controller
    {
        private IPictureStorage _pictureStorage;

        public PicturesController(IPictureStorage pictureStorage)
        {
            _pictureStorage = pictureStorage;
        }

        public IActionResult Index()
        {
            string[] arr = { "1", "2", "3" };

            return View(arr);
        }

        public IActionResult ShowPicture(string id)
        {
            return View("Picture", id);
        }
    }
}
