using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Interfaces
{
    
    public interface IFacultyRepository : IRepository<Faculty>
    {
        // IEnumerable<Faculty> GetFaculty(string code);
        IEnumerable<Faculty> Faculties { get; }
    }
}