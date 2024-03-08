using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class EmployerNavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool isAuthenticated)
        {
            if (isAuthenticated)
            {
                return View("Employer");
            }
            return View();
        }
    }
}