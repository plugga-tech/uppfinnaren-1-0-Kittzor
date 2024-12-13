using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Models;

namespace Uppfinnaren.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            ViewData["Name"] = "Robin Kjellgren";
            ViewData["Email"] = "Robin.Kjellgren@qvanum.se";
            ViewData["Phone"] = "0704123456";
            return View();
        }

        public IActionResult Alster()
        {
            var beerList = new List<Alster>
            {
                new Alster {Id = 1, Name = "Abrakadabra", Description = "Vår kraftfulla men ändå eleganta stout. Bryggd med bland annat chokladmalt och havre vilket ger ölen toner av kaffe, choklad såväl som lakritsrot.", ImageUrl = "/assets/oel1.webp"},
                new Alster {Id = 2, Name = "Röklager", Description = "Bokrökt malt gör att denna får en lätt rökigt smak.", ImageUrl = "/assets/oel2.webp"}
            };

            return View(beerList);
        }
    }
}
