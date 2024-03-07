using Jobdoon.DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Jobdoon.ViewModels;

namespace Jobdoon.Controllers
{
    public class SearchController : Controller
    {
        private readonly IUnitOfWork unit;

        public SearchController(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public IActionResult Index()
        {
            ViewBag.isEmployer = false;

            return View(new IndexViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                Categories = unit.Categories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                UnspecifiedSalaries = unit.UnspecifiedSalaries.GetAll()
            });
        }
    }
}
