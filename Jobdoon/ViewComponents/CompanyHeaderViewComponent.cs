using Jobdoon.DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.ViewComponents
{
    public class CompanyHeaderViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unit;

        public CompanyHeaderViewComponent(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public IViewComponentResult Invoke(int companyId)
        {
            return View(unit.Companies.Get(companyId));
        }
    }
}
