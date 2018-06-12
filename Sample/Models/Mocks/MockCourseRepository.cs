using Sample.Models.Concrete;
using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Mocks
{
    public class MockCourseRepository : MockRepository<Course>, ICourseRepository
    {
        //public MockCourseRepository(SampleDbContext context) : base(context)
        //{
        //}

        public MockCourseRepository()
        {
            _collection = Courses;
        }

        public IEnumerable<Course> Courses 
        {
            get
            {
                return new List<Course>
                    {
                        new Course
                        {
                             Code = "ARC102",
                              Title = "Introduction to Architecture",
                              Units = 2

                        },
                        new Course
                        {
                             Code = "ARC110",
                              Title = "Building Materials",
                              Units = 2

                        },
                        new Course
                        {
                             Code = "ARC101",
                              Title = "Design Studio",
                              Units = 6

                        }
                    };
            }
        }
        public IEnumerable<Course> GetCourseByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}