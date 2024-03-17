using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Models.Entities;
using Jobdoon.Utilities;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork unit;
        private readonly UserManager<AppUser> userManager;

        public EmployeeController(IUnitOfWork unit, UserManager<AppUser> userManager)
        {
            this.unit = unit;
            this.userManager = userManager;
        }

        public IActionResult Search()
        {
            ViewBag.Layout = "_Layout";
            return View(new SearchViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                JobCategories = unit.JobCategories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                MinimumSalaries = unit.MinimumSalaries.GetAll()
            });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SendRequest(int opportunityId)
        {
            var user = await userManager.GetUserAsync(User);

            unit.Requests.Add(new Request
            {
                EmployeeId = user.Id,
                Date = DateTime.Now,
                OpportunityId = opportunityId,
                RequestStateId = ((int)RequestStatesUtilities.Sent)
            });
            unit.Complete();
            return RedirectToAction("Requests");
        }

        [Authorize]
        public IActionResult Requests()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Index");
        }

        [Authorize]
        public IActionResult Cancelled()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Cancelled");
        }

        [Authorize]
        public IActionResult Hired()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Hired");
        }

        [Authorize]
        public IActionResult InterviewAccepted()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/InterviewAccepted");
        }

        [Authorize]
        public IActionResult Reviewed()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Reviewed");
        }

        [Authorize]
        public IActionResult Sent()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Sent");
        }

        [Authorize]
        public IActionResult Saved()
        {
            ViewBag.Layout = "_Layout";
            return View(new SearchViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                JobCategories = unit.JobCategories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                MinimumSalaries = unit.MinimumSalaries.GetAll()
            });
        }
    }
}
