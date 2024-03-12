using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Models.Entities;
using Jobdoon.Utilities;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using System.ComponentModel.Design;
using System.Net;

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

        [BindProperty]
        public CreateEditCompanyViewModel CreateCompanyViewModel { get; set; }

        [BindProperty]
        public CreateEditCompanyViewModel EditCompanyViewModel { get; set; }

        public IActionResult Index()
        {
            ViewBag.Layout = "_EmployerLayout";

            return View();
        }

        public IActionResult Dashboard()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";

            return View("Dashboard/Index");
        }

        public IActionResult EditCompany(int? companyId)
        {
            ViewBag.Layout = "_EmployerDashboardLayout";

            if (companyId == null)
            {
                return View("Dashboard/Company/Create", CreateCompanyViewModel);
            }

            var company = unit.Companies.Get(companyId.Value);
            EditCompanyViewModel = new CreateEditCompanyViewModel
            {
                Company = company
            };

            return View("Dashboard/Company/Edit", EditCompanyViewModel);
        }

        [HttpPost]
        public IActionResult UpdateCompany(int companyId)
        {
            var company = unit.Companies.Get(companyId);
            company.PersianName = EditCompanyViewModel.Company.PersianName;
            company.LatinName = EditCompanyViewModel.Company.LatinName;
            company.CategoryId = EditCompanyViewModel.Company.CategoryId;
            company.PersonnelCountId = EditCompanyViewModel.Company.PersonnelCountId;
            company.Address = EditCompanyViewModel.Company.Address;
            company.Telephone = EditCompanyViewModel.Company.Telephone;
            company.Website = EditCompanyViewModel.Company.Website;
            if (EditCompanyViewModel.LogoImageFile != null)
            {
                company.LogoImage = ImageUtilities.ImageFileToByteArray(EditCompanyViewModel.LogoImageFile);
            }

            unit.Companies.Update(company);
            unit.Complete();

            return RedirectToAction("Index", "Company", new { companyId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany()
        {
            var user = userManager.GetUserAsync(User).Result;

            unit.Companies.Add(new Company
            {
                EmployerId = user.Id,
                PersianName = CreateCompanyViewModel.Company.PersianName,
                LatinName = CreateCompanyViewModel.Company.LatinName,
                CategoryId = CreateCompanyViewModel.Company.CategoryId,
                PersonnelCountId = CreateCompanyViewModel.Company.PersonnelCountId,
                Address = CreateCompanyViewModel.Company.Address,
                Telephone = CreateCompanyViewModel.Company.Telephone,
                Website = CreateCompanyViewModel.Company.Website,
                LogoImage = ImageUtilities.ImageFileToByteArray(CreateCompanyViewModel.LogoImageFile)
            });
            unit.Complete();

            user.CompanyId = unit.Companies.Find(c => c.EmployerId == user.Id).First().Id;
            await userManager.UpdateAsync(user);

            return RedirectToAction("Index", "Company", new { user.CompanyId });
        }

        public IActionResult Opportunities()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Index");
        }

        public IActionResult ActiveOpportunities()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Active");
        }

        public IActionResult ClosedOpportunities()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Closed");
        }

        [HttpGet]
        public IActionResult NewOpportunity()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Create", CreateOpportunityModel);
        }

        [HttpPost]
        public IActionResult CreateOpportunity()
        {
            var companyId = userManager.GetUserAsync(User).Result.CompanyId;
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
                CompanyId = companyId
            });
            unit.Complete();

            return RedirectToAction("Opportunities", "Company", new { companyId = companyId.Value });
        }
    }
}
