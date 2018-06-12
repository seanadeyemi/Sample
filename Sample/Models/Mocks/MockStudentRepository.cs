using Sample.Models.Concrete;
using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Mocks
{
    public class MockStudentRepository : MockRepository<Student>, IStudentRepository
    {
        private readonly IDepartmentRepository _departmentRepository = new MockDepartmentRepository();// new SampleDbContext());
                                                                                                      //public MockStudentRepository(Students):base(context)
                                                                                                      //{

        //}

        public MockStudentRepository()
        {
            _collection = Students;
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return new List<Student>
                {
                    new Student
                    {
                        Id = 1,
                        FirstName = "Dayo",
                        LastName = "John",
                         DateOfBirth = new DateTime(1980, 9, 15),
                          Department = _departmentRepository.Departments.First(),
                           Gender = true,
                           DepartmentId = _departmentRepository.Departments.First().Id
                    },
                    new Student
                    {
                        Id = 2,
                        FirstName = "Bola",
                        LastName = "Mark",
                         DateOfBirth = new DateTime(1986, 5, 25),
                          Department = _departmentRepository.Departments.First(),
                           Gender = true,
                        DepartmentId = _departmentRepository.Departments.First().Id
                    }
                    ,
                    new Student
                    {
                        Id = 3,
                        FirstName = "Femi",
                        LastName = "Brown",
                         DateOfBirth = new DateTime(1997, 8, 12),
                          Department = _departmentRepository.Departments.ElementAt(2),
                           Gender = true,
                        DepartmentId = _departmentRepository.Departments.ElementAt(2).Id
                    }
                };

            }
            set
            {


            }

        }
        public IEnumerable<Student> GetOldestStudents(int count)
        {
            return Students.Where(c => c.DateOfBirth != null).OrderByDescending(c => c.DateOfBirth).Take(count);
        }

        //public SampleDbContext MyContext
        //{
        //    get { return this.dbContext as SampleDbContext; }
        //}
    }
}