using System.IO;
using System.Transactions;
using CurrencyConverter.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace CurrencyConverter.Services
{
    public class PictureStorage : IPictureStorage
    {
        private IHostingEnvironment _hostingEnvironment;

        public PictureStorage(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public string[] GetAllPhotos()
        {
            var path = _hostingEnvironment.WebRootPath;

            var ggg = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Trash");

          //  var f = Path.Combine(path, "images", "Trash");

            var a = Directory.GetFiles(path);

            return a;
        }

        public string GetOnePhoto(string path)
        {
            return null;
        }

        public void UploadPhoto()
        {

        }
    }
}
