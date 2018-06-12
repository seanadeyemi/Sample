using Sample.Models;
using Sample.Models.Concrete;
using Sample.Models.Mocks;
using Sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
          //var department =  new MockDepartmentRepository().Get(id);
            var department = new DepartmentRepository(new SampleDbContext()).Get(id);

            

            DepartmentDetailsViewModel dvm = new DepartmentDetailsViewModel
            {  Faculty = department.Faculty.Name,
                FacultyId = department.Faculty.Id,
                 Name = department.Name
             };
            ViewBag.Dvm = dvm;


            return View(dvm);
        }
    }
}