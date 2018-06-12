using Sample.Models.Mocks;
using Sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var university = new MockUniversityRepository().Get(id);
            UniversityDetailsViewModel uvm = new UniversityDetailsViewModel
            {
              
                Name = university.Name,
              Location = university.Location
            };
            return View(uvm);
        }
    }
}