using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Database;
using Jobdoon.Models;
using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Jobdoon.ViewModels;
namespace Jobdoon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unit;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unit)
        {
            _logger = logger;
            this.unit = unit;
        }

        public IActionResult Index()
        {
            ViewBag.isEmployer = false;


            return View(new IndexViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                Categories = unit.Categories.GetAll()
            });
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
