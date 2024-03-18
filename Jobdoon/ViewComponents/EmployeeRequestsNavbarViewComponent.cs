using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class EmployeeRequestsNavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string activeTab)
        {
            return View(model: activeTab);
        }
    }
}