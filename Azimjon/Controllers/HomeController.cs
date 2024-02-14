using System.Diagnostics;
using Azimjon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Azimjon.Controllers
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

        public IActionResult Maqolalar()
        {
            return View();
        }
        
        public IActionResult Monografiya()
        {
            return View();
        }
        
        public IActionResult Adabiyotlar()
        {
            return View();
        }
        
        public IActionResult Muallif()
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
