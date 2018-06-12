using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Interfaces
{
    
    public interface ILecturerRepository : IRepository<Lecturer>
    {
        //  IEnumerable<Course> GetCourseByCode(string code);
        IEnumerable<Lecturer> Lecturers { get; }
    }
}