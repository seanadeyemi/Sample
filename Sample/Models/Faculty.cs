using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }


        public virtual University University { get; set; }
        public int UniversityId { get; set; }

    }
}