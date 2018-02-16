using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        //[Index("IX_CourseIdStudentId", 1, IsUnique = true)]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        //[Index("IX_CourseIdStudentId", 2, IsUnique = true)]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public string Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}