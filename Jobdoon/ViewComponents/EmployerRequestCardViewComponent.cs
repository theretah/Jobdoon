using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class EmployerRequestCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Request> requests)
        {
            return View(requests);
        }
    }
}