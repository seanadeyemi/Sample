using Sample.Models.Concrete;
using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Mocks
{
    public class MockUniversityRepository : MockRepository<University>, IUniversityRepository
    {
        //private readonly IFacultyRepository _facultyRepository = new MockFacultyRepository();// new SampleDbContext());

        public MockUniversityRepository()
        {
            _collection = Universities;
        }

        //public MockUniversityRepository(SampleDbContext context) : base(context)
        //{
        //}

        public IEnumerable<University> Universities
        {
            get
            {
                return new List<University>
                {
                    new University
                    {
                        Id = 1,
                        Name = "University Of Lagos",
                        Location = "Akoka"
                    }

                };
            }

        }
        public University GetUniversity()
        {
            return Universities.First();
        }
    }
}