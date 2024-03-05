using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class EmployerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.isEmployer = true;
            return View();
        }
    }
}
