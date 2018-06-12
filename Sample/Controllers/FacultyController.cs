using Sample.Models.Mocks;
using Sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var faculty = new MockFacultyRepository().Get(id);
            FacultyDetailsViewModel fvm = new FacultyDetailsViewModel
            {
                Code = faculty.Code,
                Name = faculty.Name,
                University = faculty.University.Name,
                UniversityId = faculty.University.Id
            };
            return View(fvm);
        }
    }
}