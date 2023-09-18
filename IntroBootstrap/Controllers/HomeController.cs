using IntroBootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntroBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ejemplos2()
        {
            return View();
        }

        public IActionResult Imagenes()
        {
            return View();
        }
        public IActionResult Tablas()
        {
            return View();
        }
        public IActionResult Video()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}