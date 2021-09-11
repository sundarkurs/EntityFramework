using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirst.Models
{
    public partial class CourseLevel
    {
        public CourseLevel()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
