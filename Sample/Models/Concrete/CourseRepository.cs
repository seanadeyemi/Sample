using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Concrete
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(SampleDbContext context):base(context)
        {

        }

        public IEnumerable<Course> GetCourseByCode(string code)
        {
          return  MyContext.Courses.Where(c => c.Code == code).ToList();
        }
        public SampleDbContext MyContext
        {
            get { return this.dbContext as SampleDbContext; }
        }
        public IEnumerable<Course> Courses
        {
            get { return dbContext.Courses; }
        }
    }
}