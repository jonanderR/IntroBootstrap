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
        public IActionResult Tamanyos()
        {
            return View();
        }
        public IActionResult Espacios()
        {
            return View();
        }
        public IActionResult Utilidades()
        {
            return View();
        }
        public IActionResult Formularios()
        {
            return View();
        }
        public IActionResult Acordeon()
        {
            return View();
        }
        public IActionResult Alertas()
        {
            return View();
        }
        public IActionResult Carousel()
        {
            return View();
        }
        public IActionResult Modales()
        {
            return View();
        }
        public IActionResult Tabs()
        {
            return View();
        }

        public IActionResult OffCanvas()
        {
            return View();
        }
        public IActionResult Toast()
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