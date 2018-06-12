using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class SampleUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<SampleUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class SampleDbContext : IdentityDbContext<SampleUser>
    {
        public SampleDbContext()// : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
       
        public static SampleDbContext Create()
        {
            return new SampleDbContext();
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<University> Universities { get; set; }
        public DbSet<Department> Departments { get; internal set; }
    }
}