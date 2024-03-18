using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.Models.Entities;
using Jobdoon.Utilities;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        [BindProperty]
        public Opportunity EditOpportunityModel { get; set; }

        [BindProperty]
        public CreateEditCompanyViewModel CreateCompanyViewModel { get; set; }
        [BindProperty]
        public CreateEditCompanyViewModel EditCompanyViewModel { get; set; }

        public IActionResult Index()
        {
            if (signInManager.IsSignedIn(User))
                if (!IsEmployer())
                    return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerLayout";

            return View();
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";

            return View("Dashboard/Opportunities/Index");
        }

        [Authorize]
        public IActionResult EditCompany(int? companyId)
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";

            if (companyId == null)
            {
                ViewBag.Layout = "_Layout";
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
        [Authorize]
        public IActionResult UpdateCompany(int companyId)
        {
            var company = unit.Companies.Get(companyId);
            company.PersianName = EditCompanyViewModel.Company.PersianName;
            company.LatinName = EditCompanyViewModel.Company.LatinName;
            company.CompanyCategoryId = EditCompanyViewModel.Company.CompanyCategoryId;
            company.PersonnelCountId = EditCompanyViewModel.Company.PersonnelCountId;
            company.Address = EditCompanyViewModel.Company.Address;
            company.Telephone = EditCompanyViewModel.Company.Telephone;
            company.Website = EditCompanyViewModel.Company.Website;
            company.IntroductoryText = EditCompanyViewModel.Company.IntroductoryText;
            if (EditCompanyViewModel.LogoImageFile != null)
            {
                company.LogoImage = FileUtilities.FileToByteArray(EditCompanyViewModel.LogoImageFile);
            }
            if (EditCompanyViewModel.BuildingImageFile != null)
            {
                company.BuildingImage = FileUtilities.FileToByteArray(EditCompanyViewModel.BuildingImageFile);
            }
            if (EditCompanyViewModel.BannerImageFile != null)
            {
                company.BannerImage = FileUtilities.FileToByteArray(EditCompanyViewModel.BannerImageFile);
            }

            unit.Companies.Update(company);
            unit.Complete();

            return RedirectToAction("Index", "Company", new { companyId });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCompany()
        {
            var user = await userManager.GetUserAsync(User);

            unit.Companies.Add(new Company
            {
                EmployerId = user.Id,
                PersianName = CreateCompanyViewModel.Company.PersianName,
                LatinName = CreateCompanyViewModel.Company.LatinName,
                CompanyCategoryId = CreateCompanyViewModel.Company.CompanyCategoryId,
                PersonnelCountId = CreateCompanyViewModel.Company.PersonnelCountId,
                Address = CreateCompanyViewModel.Company.Address,
                Telephone = CreateCompanyViewModel.Company.Telephone,
                Website = CreateCompanyViewModel.Company.Website,
                IntroductoryText = CreateCompanyViewModel.Company.IntroductoryText,
                LogoImage = FileUtilities.FileToByteArray(CreateCompanyViewModel.LogoImageFile),
                BannerImage = FileUtilities.FileToByteArray(EditCompanyViewModel.BannerImageFile),
                BuildingImage = FileUtilities.FileToByteArray(EditCompanyViewModel.BuildingImageFile),
            });
            unit.Complete();

            user.CompanyId = unit.Companies.Find(c => c.EmployerId == user.Id).First().Id;
            await userManager.UpdateAsync(user);

            return RedirectToAction("Index", "Company", new { user.CompanyId });
        }

        [Authorize]
        public IActionResult Opportunities()
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Index");
        }

        [Authorize]
        public IActionResult ActiveOpportunities()
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Active");
        }

        [Authorize]
        public IActionResult ClosedOpportunities()
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Closed");
        }

        [HttpGet]
        [Authorize]
        public IActionResult NewOpportunity()
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Opportunities/Create", CreateOpportunityModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateOpportunity()
        {
            var companyId = (await userManager.GetUserAsync(User)).CompanyId;
            unit.Opportunities.Add(new Opportunity
            {
                Title = CreateOpportunityModel.Title,
                Description = CreateOpportunityModel.Description,
                Date = DateTime.Now,
                AssignmentId = CreateOpportunityModel.AssignmentId,
                JobCategoryId = CreateOpportunityModel.JobCategoryId,
                MinimumSalaryId = CreateOpportunityModel.MinimumSalaryId,
                MilitaryServiceId = CreateOpportunityModel.MilitaryServiceId,
                ExperienceId = CreateOpportunityModel.ExperienceId,
                ProvinceId = CreateOpportunityModel.ProvinceId,
                DegreeId = CreateOpportunityModel.DegreeId,
                GenderId = CreateOpportunityModel.GenderId,
                CompanyId = companyId
            });
            unit.Complete();

            return RedirectToAction("Index", "Company", new { companyId = companyId.Value });
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditOpportunity(int opportunityId)
        {
            if (!IsEmployer())
                return RedirectToAction("Error", "Home");

            ViewBag.Layout = "_EmployerDashboardLayout";
            EditOpportunityModel = unit.Opportunities.Get(opportunityId);
            return View("Dashboard/Opportunities/Edit", EditOpportunityModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult UpdateOpportunity(int opportunityId)
        {
            var opportunity = unit.Opportunities.Get(opportunityId);
            opportunity.Title = EditOpportunityModel.Title;
            opportunity.Description = EditOpportunityModel.Description;
            opportunity.AssignmentId = EditOpportunityModel.AssignmentId;
            opportunity.JobCategoryId = EditOpportunityModel.JobCategoryId;
            opportunity.MinimumSalaryId = EditOpportunityModel.MinimumSalaryId;
            opportunity.MilitaryServiceId = EditOpportunityModel.MilitaryServiceId;
            opportunity.ExperienceId = EditOpportunityModel.ExperienceId;
            opportunity.ProvinceId = EditOpportunityModel.ProvinceId;
            opportunity.DegreeId = EditOpportunityModel.DegreeId;
            opportunity.GenderId = EditOpportunityModel.GenderId;

            unit.Opportunities.Update(opportunity);
            unit.Complete();

            return RedirectToAction("Index", "Company", new { companyId = opportunity.CompanyId.Value });
        }

        [HttpPost]
        [Authorize]
        public IActionResult CloseOpportunity(int opportunityId)
        {
            var opportunity = unit.Opportunities.Get(opportunityId);
            opportunity.IsClosed = true;

            unit.Opportunities.Update(opportunity);
            unit.Complete();

            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        [Authorize]
        public IActionResult ActivateOpportunity(int opportunityId)
        {
            var opportunity = unit.Opportunities.Get(opportunityId);
            opportunity.IsClosed = false;

            unit.Opportunities.Update(opportunity);
            unit.Complete();

            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        [Authorize]
        public IActionResult RemoveOpportunity(int opportunityId)
        {
            var opportunity = unit.Opportunities.Get(opportunityId);
            unit.Opportunities.Remove(opportunity);
            unit.Complete();

            return RedirectToAction("Dashboard");
        }

        private bool IsEmployer()
        {
            return userManager.GetUserAsync(User).Result.IsEmployer == true;
        }

        [Authorize]
        public IActionResult Requests()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Requests/Index");
        }

        [Authorize]
        public IActionResult Cancelled()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Requests/Cancelled");
        }

        [Authorize]
        public IActionResult Hired()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Requests/Hired");
        }

        [Authorize]
        public IActionResult InterviewAccepted()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Requests/InterviewAccepted");
        }

        [Authorize]
        public IActionResult Reviewed()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Requests/Reviewed");
        }

        [Authorize]
        public IActionResult Sent()
        {
            ViewBag.Layout = "_EmployerDashboardLayout";
            return View("Dashboard/Requests/Sent");
        }
    }
}
