using Jobdoon.DataAccess.UnitOfWork;
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
        private readonly IUnitOfWork unit;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IUnitOfWork unit)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.unit = unit;
        }

        [BindProperty]
        public AppUser AppUser { get; set; }

        [BindProperty]
        public int BirthDay { get; set; }
        [BindProperty]
        public int BirthMonth { get; set; }
        [BindProperty]
        public int BirthYear { get; set; }

        public List<Gender> Genders { get; set; }

        [Authorize]
        public IActionResult Index()
        {
            ViewBag.Layout = "_Layout";
            AppUser = userManager.GetUserAsync(User).Result;
            return View(new AccountViewModel
            {
                AppUser = AppUser,
                BirthDay = AppUser.BirthDate.Value.Day,
                BirthMonth = AppUser.BirthDate.Value.Month,
                BirthYear = AppUser.BirthDate.Value.Year,
            });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile()
        {
            var user = userManager.GetUserAsync(User).Result;
            var genders = unit.Genders.GetValids().ToList();

            user.FullName = AppUser.FullName;
            user.PhoneNumber = AppUser.PhoneNumber;

            user.Email = AppUser.Email;
            user.NormalizedEmail = AppUser.NormalizedEmail;
            user.UserName = AppUser.Email;
            user.NormalizedUserName = AppUser.NormalizedEmail;

            user.BirthDate = new DateTime(BirthYear, BirthMonth, BirthDay);
            user.DegreeId = AppUser.DegreeId;
            user.GenderId = AppUser.GenderId;
            if (user.GenderId == genders[0].Id)
            {
                user.MilitaryServiceId = AppUser.MilitaryServiceId;
            }
            else
            {
                user.MilitaryServiceId = null;
            }

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
