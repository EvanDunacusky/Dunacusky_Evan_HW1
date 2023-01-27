using Microsoft.AspNetCore.Mvc;

namespace Dunacusky_Evan_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult AFewFavs()
        {
            return View();
        }

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Evan Dunacusky Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Evan Dunacusky Resume.pdf");
        }
    }
}