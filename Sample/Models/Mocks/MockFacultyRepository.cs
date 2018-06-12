using Sample.Models.Concrete;
using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Mocks
{
    public class MockFacultyRepository : MockRepository<Faculty>, IFacultyRepository
    {
        private readonly IUniversityRepository _universityRepository = new MockUniversityRepository();// new SampleDbContext());
        //private readonly IDepartmentRepository _departmentRepository = new MockDepartmentRepository();// new SampleDbContext());

        public MockFacultyRepository()
        {
            _collection = Faculties;
        }

        //public MockFacultyRepository(SampleDbContext context) : base(context)
        //{
        //}

        public IEnumerable<Faculty> Faculties
        {
            get
            {
                return new List<Faculty>
                    {
                        new Faculty
                        {
                            Id = 1,
                             Code = "ES",
                              Name = "Environmental Science",
                               University = _universityRepository.GetUniversity()//_universityRepository.GetUniversity(),
                               

                        },
                        new Faculty
                        {
                            Id = 2,
                             Code = "ENG",
                             Name = "Engineering",
                             University = _universityRepository.GetUniversity()
                        }
                    };
            }
        }
    }
}