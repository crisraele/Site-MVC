using AgenciadeViagens.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgenciadeViagens.Controllers
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

        public IActionResult Promo()
        {
            return View(Promo);
        }
        public IActionResult Destino()
        {
            return View(Destino);
        }
        public IActionResult Contato()
        {
            return View(Contato);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}