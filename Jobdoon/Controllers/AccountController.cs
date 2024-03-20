using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Models.Entities;
using Jobdoon.Utilities;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

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
        public AccountViewModel Account { get; set; }

        public List<Gender> Genders { get; set; }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            ViewBag.Layout = "_Layout";

            var user = await userManager.GetUserAsync(User);
            user.ResumeAppendix = unit.Resumes.GetByEmployeeId(user.Id);
            Account = new AccountViewModel
            {
                AppUser = user
            };

            if (user.IsEmployer || Account.AppUser.BirthDate == null)
            {
                return View(Account);
            }

            return View(new AccountViewModel
            {
                AppUser = Account.AppUser,
                BirthDay = Account.AppUser.BirthDate.Value.Day,
                BirthMonth = Account.AppUser.BirthDate.Value.Month,
                BirthYear = Account.AppUser.BirthDate.Value.Year,
            }); ;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile()
        {
            var user = await userManager.GetUserAsync(User);
            var genders = unit.Genders.GetValids().ToList();

            user.FullName = Account.AppUser.FullName;
            user.PhoneNumber = Account.AppUser.PhoneNumber;
            user.Email = Account.AppUser.Email;
            user.NormalizedEmail = Account.AppUser.NormalizedEmail;
            user.UserName = Account.AppUser.Email;
            user.NormalizedUserName = Account.AppUser.NormalizedEmail;

            if (!user.IsEmployer)
            {
                user.BirthDate = new DateTime(Account.BirthYear, Account.BirthMonth, Account.BirthDay);
                user.DegreeId = Account.AppUser.DegreeId;
                user.GenderId = Account.AppUser.GenderId;
                if (Account.ProfileImageFile != null)
                {
                    var imageBytes = FileUtilities.FileToByteArray(Account.ProfileImageFile);
                    if (user.ProfileImage != imageBytes)
                    {
                        user.ProfileImage = imageBytes;
                    }
                }
                if (Account.ResumeAppendixFile != null)
                {
                    var inputResume = new Resume
                    {
                        Content = FileUtilities.FileToByteArray(Account.ResumeAppendixFile),
                        FileName = Account.ResumeAppendixFile.FileName,
                        EmployeeId = user.Id,
                        Employee = user
                    };

                    var userResume = unit.Resumes.GetByEmployeeId(user.Id);
                    if (userResume == null)
                    {
                        // Add resume
                        unit.Resumes.Add(inputResume);
                        unit.Complete();
                        user.ResumeAppendix = inputResume;
                        user.ResumeAppendixId = unit.Resumes.GetByEmployeeId(user.Id).Id;
                    }
                    else
                    {
                        // Update current resume
                        userResume.FileName = inputResume.FileName;
                        userResume.Content = inputResume.Content;
                        unit.Resumes.Update(userResume);
                    }
                }

                if (user.GenderId == genders[0].Id)
                {
                    user.MilitaryServiceId = Account.AppUser.MilitaryServiceId;
                }
                else
                {
                    user.MilitaryServiceId = null;
                }
            }
            await userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Home", null);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home", null);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveProfilePhoto()
        {
            var user = await userManager.GetUserAsync(User);
            user.ProfileImage = null;
            await userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveResumeAppendix()
        {
            var user = await userManager.GetUserAsync(User);
            unit.Resumes.Remove(user.ResumeAppendixId.Value);
            unit.Complete();

            user.ResumeAppendix = null;
            user.ResumeAppendixId = null;
            await userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DownloadResumeFile(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            var resume = unit.Resumes.GetByEmployeeId(userId);

            var contentType = "application/pdf";

            return File(new MemoryStream(resume.Content), contentType, $"{user.FullName.Replace(" ", "_")}_ResumeFile.pdf");
        }
    }
}
