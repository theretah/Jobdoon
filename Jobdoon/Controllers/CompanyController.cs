﻿using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork unit;

        public CompanyController(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public IActionResult Index(int companyId)
        {
            ViewBag.Layout = "_Layout";
            var company = unit.Companies.Get(companyId);

            return View(company);
        }

        [Authorize]
        public IActionResult OpportunityDetails(int opportunityId)
        {
            ViewBag.Layout = "_Layout";
            var opportunity = unit.Opportunities.Get(opportunityId);

            return View(new CompanyOpportunityViewModel
            {
                Company = unit.Companies.Get(opportunity.CompanyId.Value),
                Opportunity = opportunity
            });
        }
    }
}
