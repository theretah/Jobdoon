﻿using Jobdoon.DataAccess.UnitOfWork;
using Jobdoon.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
                JobCategories = unit.JobCategories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                MinimumSalaries = unit.MinimumSalaries.GetAll()
            });
        }

        [Authorize]
        public IActionResult Requests()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Index");
        }

        [Authorize]
        public IActionResult Cancelled()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Cancelled");

        }

        [Authorize]
        public IActionResult Hired()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Hired");
        }

        [Authorize]
        public IActionResult InterviewAccepted()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/InterviewAccepted");
        }

        [Authorize]
        public IActionResult Reviewed()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Reviewed");
        }

        [Authorize]
        public IActionResult Sent()
        {
            ViewBag.Layout = "_Layout";
            return View("Requests/Sent");
        }

        [Authorize]
        public IActionResult Saved()
        {
            ViewBag.Layout = "_Layout";
            return View(new SearchViewModel
            {
                Provinces = unit.Provinces.GetAll(),
                JobCategories = unit.JobCategories.GetAll(),
                Assignments = unit.Assignments.GetAll(),
                Experiences = unit.Experiences.GetAll(),
                MinimumSalaries = unit.MinimumSalaries.GetAll()
            });
        }
    }
}
