using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.isEmployer = false;

            return View();
        }
    }
}
