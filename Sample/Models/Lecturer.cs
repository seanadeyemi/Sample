﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}