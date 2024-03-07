using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class EmployerController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public EmployerController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }
    }
}
