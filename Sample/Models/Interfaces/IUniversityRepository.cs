using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Interfaces
{
    public interface IUniversityRepository
    {
        University GetUniversity();
        IEnumerable<University> Universities { get; }
    }
}