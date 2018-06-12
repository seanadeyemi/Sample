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
    public class StudentController : Controller
    {
        UnitOfWork _uow;
        public StudentController()
        {
            _uow = new UnitOfWork();
        }

        //public StudentController(UnitOfWork uow)
        //{
        //    _uow = uow;
        //}
        // GET: Student
        public ActionResult Index()
        {
            var students = _uow.Students.GetAll();



            //var students = new StudentRepository(new SampleDbContext()).GetAll();////_uow.Students.GetAll();//.GetAllStudents();
            //var students = new MockStudentRepository().GetAll();
            StudentIndexViewModel svm = new StudentIndexViewModel();
            svm.Students = students.ToList();
            return View(svm);
        }
        public ActionResult Details()
        {
            return View();
        }

    }
}