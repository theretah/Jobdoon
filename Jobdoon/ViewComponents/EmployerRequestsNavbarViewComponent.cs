using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class EmployerRequestsNavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string activeTab)
        {
            return View(model: activeTab);
        }
    }
}