using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCSurvivalGame.Models;

namespace MVCSurvivalGame.Controllers
{
    public class MainMenuController : Controller
    {
        private readonly ILogger<MainMenuController> _logger;

        public MainMenuController(ILogger<MainMenuController> logger)
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
    }
}
