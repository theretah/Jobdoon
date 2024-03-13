using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Jobdoon.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork unit;

        public EmployeeController(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public IActionResult Search()
        {
            ViewBag.Layout = "_Layout";
            return View(new SearchViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                Categories = unit.Categories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                UnspecifiedSalaries = unit.MinimumSalaries.GetAll()
            });
        }

        public IActionResult Requests()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Index");
        }
        public IActionResult Cancelled()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Cancelled");

        }
        public IActionResult Hired()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Hired");
        }
        public IActionResult InterviewAccepted()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/InterviewAccepted");
        }
        public IActionResult Reviewed()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Reviewed");
        }
        public IActionResult Sent()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Sent");
        }

        public IActionResult Saved()
        {
            ViewBag.Layout = "_Layout";
            return View(new SearchViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                Categories = unit.Categories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                UnspecifiedSalaries = unit.MinimumSalaries.GetAll()
            });
        }
    }
}
