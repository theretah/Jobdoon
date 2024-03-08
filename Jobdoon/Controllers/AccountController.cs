using Jobdoon.Models.Entities;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [BindProperty]
        public AppUser AppUser { get; set; }

        [BindProperty]
        public int BirthDay { get; set; }
        [BindProperty]
        public int BirthMonth { get; set; }
        [BindProperty]
        public int BirthYear { get; set; }

        [Authorize]
        public IActionResult Index()
        {
            AppUser = userManager.GetUserAsync(User).Result;
            ViewBag.Layout = "_Layout";

            return View(new AccountViewModel
            {
                AppUser = AppUser,
                BirthDay = AppUser.BirthDate.Value.Day,
                BirthMonth = AppUser.BirthDate.Value.Month,
                BirthYear = AppUser.BirthDate.Value.Year
            });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile()
        {
            var user = userManager.GetUserAsync(User).Result;

            user.FullName = AppUser.FullName;
            user.PhoneNumber = AppUser.PhoneNumber;

            user.Email = AppUser.Email;
            user.NormalizedEmail = AppUser.NormalizedEmail;
            user.UserName = AppUser.Email;
            user.NormalizedUserName = AppUser.NormalizedEmail;

            user.BirthDate = new DateTime(BirthYear, BirthMonth, BirthDay);
            user.DegreeId = AppUser.DegreeId;
            user.GenderId = AppUser.GenderId;
            user.MilitaryServiceId = AppUser.MilitaryServiceId;

            await userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Home", null);
        }
        public IActionResult Logout()
        {
            signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home", null);
        }
    }
}
