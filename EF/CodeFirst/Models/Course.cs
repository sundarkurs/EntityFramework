using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirst.Models
{
    public partial class Course
    {
        public Course()
        {
            UserCourses = new HashSet<UserCourse>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Level { get; set; }

        public virtual CourseLevel LevelNavigation { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
