using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LexiconUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        // Navigational property
        public virtual ICollection<Enrollment> Enrollments { get; set; }    
    }
}