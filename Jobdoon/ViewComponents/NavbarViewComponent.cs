using Jobdoon.Models.Entities;
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
    public class RequestCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Request request)
        {
            return View(request);
        }
    }
}