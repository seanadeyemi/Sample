using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Concrete
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {

        public StudentRepository(SampleDbContext context):base(context)
        {
                
        }

        public IEnumerable<Student> GetOldestStudents(int count)
        {
            return MyContext.Students.Where(c => c.DateOfBirth != null).OrderByDescending(c => c.DateOfBirth).Take(count);
        }

        public SampleDbContext MyContext
        {
            get { return this.dbContext as SampleDbContext; }
        }

        public IEnumerable<Student> Students
        {
            get { return dbContext.Students; }
        }
    }
}