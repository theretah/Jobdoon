using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Models.Entities;
using Jobdoon.Utilities;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        [BindProperty(SupportsGet = true)]
        public SearchViewModel SearchModel { get; set; } = new SearchViewModel();

        public void ApplySelectedOptions(SearchViewModel searchModel)
        {
            searchModel.JobCategoriesSelectList =
                new SelectList(unit.JobCategories.GetAll(), nameof(JobCategory.Id), nameof(JobCategory.Title));
            if (SearchModel.SelectedJobCategories.Count() > 0)
            {
                searchModel.Opportunities = searchModel.Opportunities.Where(o =>
                    searchModel.SelectedJobCategories.Contains(o.JobCategoryId));
            }

            searchModel.AssignmentsSelectList =
                new SelectList(unit.Assignments.GetAll(), nameof(Assignment.Id), nameof(Assignment.Title));
            if (SearchModel.SelectedAssignments.Count() > 0)
            {
                searchModel.Opportunities = searchModel.Opportunities.Where(o =>
                    searchModel.SelectedAssignments.Contains(o.AssignmentId));
            }

            searchModel.ProvincesSelectList =
               new SelectList(unit.Provinces.GetAll(), nameof(Province.Id), nameof(Province.Name));
            if (SearchModel.SelectedProvinces.Count() > 0)
            {
                searchModel.Opportunities = searchModel.Opportunities.Where(o =>
                    searchModel.SelectedProvinces.Contains(o.ProvinceId));
            }

            searchModel.ExperiencesSelectList =
              new SelectList(unit.Experiences.GetAll(), nameof(Experience.Id), nameof(Experience.Title));
            if (SearchModel.SelectedExperiences.Count() > 0)
            {
                searchModel.Opportunities = searchModel.Opportunities.Where(o =>
                    searchModel.SelectedExperiences.Contains(o.ExperienceId));
            }

            searchModel.SalariesSelectList =
              new SelectList(unit.MinimumSalaries.GetAll(), nameof(MinimumSalary.Id),
              nameof(MinimumSalary.ActualValue));
            if (SearchModel.SelectedSalaries.Count() > 0)
            {
                searchModel.Opportunities = searchModel.Opportunities.Where(o =>
                    searchModel.SelectedSalaries.Contains(o.MinimumSalaryId));
            }
        }

        public IActionResult Search()
        {
            ViewBag.Layout = "_Layout";

            SearchModel.Opportunities = unit.Opportunities.GetAll();

            ApplySelectedOptions(SearchModel);

            if (SearchModel.SearchQuery != null)
            {
                SearchModel.Opportunities = unit.Opportunities.Find(o =>
                    o.Title.ToLower().Contains(SearchModel.SearchQuery.ToLower()) ||
                    o.Company.LatinName.ToLower().Contains(SearchModel.SearchQuery.ToLower()) ||
                    o.Company.PersianName.Contains(SearchModel.SearchQuery.ToLower()))
                    .ToList();
            }

            return View(SearchModel);
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
            return View();
        }
    }
}
