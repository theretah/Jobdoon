using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class RequestCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Request request)
        {
            return View(request);
        }
    }
}