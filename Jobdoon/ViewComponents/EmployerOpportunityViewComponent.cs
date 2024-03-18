using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class EmployerOpportunityViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Opportunity opportunity)
        {
            return View(opportunity);
        }
    }
}