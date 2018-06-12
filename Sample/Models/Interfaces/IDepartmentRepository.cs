using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Interfaces
{
    
    public interface IDepartmentRepository : IRepository<Department>
    {
        IEnumerable<Department> Departments { get; }
    }
}