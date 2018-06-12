using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SampleDbContext context):base(context)
        {

        }

        public SampleDbContext MyContext
        {
            get { return this.dbContext as SampleDbContext; }
        }
        public IEnumerable<Department> Departments
        {
            get { return dbContext.Departments; }
        }
    }
}