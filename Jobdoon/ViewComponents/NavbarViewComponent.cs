using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool isAuthenticated, bool isEmployer)
        {
            if (isAuthenticated)
            {
                if (isEmployer)
                    return View("Employer");

                return View("Employee");
            }

            return View();
        }
    }
}