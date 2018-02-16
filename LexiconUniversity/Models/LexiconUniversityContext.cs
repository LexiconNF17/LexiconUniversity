using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class LexiconUniversityContext : DbContext
    {
     
        public LexiconUniversityContext() : base("name=LexiconUniversityContext")
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<LexiconUniversity.Models.Enrollment> Enrollments { get; set; }
    }
}
