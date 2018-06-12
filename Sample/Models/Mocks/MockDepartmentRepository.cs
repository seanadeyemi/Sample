using Sample.Models.Concrete;
using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Mocks
{
    public class MockDepartmentRepository : MockRepository<Department>, IDepartmentRepository
    {
        private readonly IFacultyRepository _facultyRepository = new MockFacultyRepository();// new SampleDbContext());
        //private readonly IStudentRepository _studentRepository = new MockStudentRepository();// new SampleDbContext());
        //private readonly ICourseRepository _courseRepository = new MockCourseRepository();// new SampleDbContext());
        //public MockDepartmentRepository(SampleDbContext context):base(context)
        //{
                
        //}

        public MockDepartmentRepository()
        {
            _collection = Departments;
        }

        public IEnumerable<Department> Departments
        {
            get
            {
                return new List<Department>
                {
                    new Department
                    {
                        Id = 1,
                         Name = "Architecture",

                        Faculty =  _facultyRepository.Faculties.First()



                    },
                    new Department
                    {
                        Id=2,
                         Name = "Building",

                        Faculty =  _facultyRepository.Faculties.First()

                    },
                    new Department
                    {
                        Id = 3,
                        Name = "Electrical Engineering",
                        Faculty = _facultyRepository.Get(2)
                    }
                    
                };

            }
            set
            {


            }

        }
        public IEnumerable<Department> GetDepartmentByName(string name)
        {
            return Departments.Where(c => c.Name == name);//.OrderByDescending(c => c.DateOfBirth).Take(count);
        }

        //public SampleDbContext MyContext
        //{
        //    get { return this.dbContext as SampleDbContext; }
        //}
    }
}