using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
