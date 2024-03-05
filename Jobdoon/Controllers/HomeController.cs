using Jobdoon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jobdoon.Controllers
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
            ViewBag.isEmployer = false;

            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.isEmployer = false;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
