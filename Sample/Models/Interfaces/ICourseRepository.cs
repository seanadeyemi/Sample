using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Interfaces
{
    
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetCourseByCode(string code);
        IEnumerable<Course> Courses { get; }
    }
}