using Sample.Models.Interfaces;
using Sample.Models.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleDbContext _context;

        public UnitOfWork()//SampleDbContext context)
        {
            // _context = context;
            Courses = new MockCourseRepository();// _context);//new CourseRepository(_context);
            Students = new MockStudentRepository();// _context);

        }
        public ICourseRepository Courses { get; private set; }

        public IStudentRepository Students  { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}