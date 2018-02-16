namespace LexiconUniversity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using LexiconUniversity.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconUniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LexiconUniversity.Models.LexiconUniversityContext";
        }

        protected override void Seed(LexiconUniversityContext context)
        {
            context.Courses.AddOrUpdate(
                c => c.CourseId,
                new Course { CourseId = 1050, Title = ".NET", Credits = 30 },
                new Course { CourseId = 1060, Title = "Java", Credits = 28 },
                new Course { CourseId = 2010, Title = "Haskell", Credits = 42 }
            );

            var students = new[] {
                new Student {  FirstName = "Adam", LastName = "Andersson" },
                new Student {  FirstName = "Berit", LastName = "Bosson" },
                new Student {  FirstName = "Cecilia", LastName = "Carlsson" },
                new Student {  FirstName = "David", LastName = "Duke" }
            };
            context.Students.AddOrUpdate(
                s => new { s.FirstName, s.LastName },
                students
            );

            context.SaveChanges();

            var enrollments = new[] {
                new Enrollment { StudentId = students[0].Id, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-01-12"), Grade = "MVG" },
                new Enrollment { StudentId = students[1].Id, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-02-02"), Grade = "VG" },
                new Enrollment { StudentId = students[0].Id, CourseId = 1060, EnrollmentDate = DateTime.Today  },
                new Enrollment { StudentId = students[1].Id, CourseId = 1060, EnrollmentDate = DateTime.Today  },
                new Enrollment { StudentId = students[2].Id, CourseId = 1060, EnrollmentDate = DateTime.Parse("2016-12-21"), Grade = "VG" },
                new Enrollment { StudentId = students[3].Id, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-01-14"), Grade = "G" },
            };
            context.Enrollments.AddOrUpdate(
                e => new { e.StudentId, e.CourseId },
                enrollments
            );

            context.SaveChanges();

        }
    }
}
