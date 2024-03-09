using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class EmployerController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly IUnitOfWork unit;
        private readonly UserManager<AppUser> userManager;

        public EmployerController(SignInManager<AppUser> signInManager, IUnitOfWork unit, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.unit = unit;
            this.userManager = userManager;
        }

        [BindProperty]
        public Opportunity CreateOpportunityModel { get; set; }

        public IActionResult Index()
        {
            ViewBag.Layout = "_EmployerLayout";

            return View();
        }

        public IActionResult Dashboard()
        {
            ViewBag.Layout = "_EmployerLayout";

            return View("Dashboard/Index");
        }

        public IActionResult EditCompany()
        {
            ViewBag.Layout = "_EmployerLayout";

            return View("Dashboard/Company/Edit");
        }

        public IActionResult Opportunities()
        {
            ViewBag.Layout = "_EmployerLayout";

            return View("Dashboard/Opportunities/Index");
        }

        public IActionResult ActiveOpportunities()
        {
            ViewBag.Layout = "_EmployerLayout";
            return View("Dashboard/Opportunities/Active");
        }

        public IActionResult ClosedOpportunities()
        {
            ViewBag.Layout = "_EmployerLayout";
            return View("Dashboard/Opportunities/Closed");
        }

        [HttpGet]
        public IActionResult NewOpportunity()
        {
            ViewBag.Layout = "_EmployerLayout";

            return View("Dashboard/Opportunities/Create", CreateOpportunityModel);
        }

        [HttpPost]
        public IActionResult CreateOpportunity()
        {
            unit.Opportunities.Add(new Opportunity
            {
                Title = CreateOpportunityModel.Title,
                Description = CreateOpportunityModel.Description,
                Date = DateTime.Now,
                AssignmentId = CreateOpportunityModel.AssignmentId,
                CategoryId = CreateOpportunityModel.CategoryId,
                MinimumSalaryId = CreateOpportunityModel.MinimumSalaryId,
                MilitaryServiceId = CreateOpportunityModel.MilitaryServiceId,
                ExperienceId = CreateOpportunityModel.ExperienceId,
                ProvinceId = CreateOpportunityModel.ProvinceId,
                DegreeId = CreateOpportunityModel.DegreeId,
                GenderId = CreateOpportunityModel.GenderId,
            });
            unit.Complete();

            // Later, the action must return to Views/Company/Opportunities
            return View("Dashboard/Index");
        }
    }
}
