using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IStudentRepository Students { get; }

        int Complete();
    }
}