using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirst.Models
{
    public partial class User
    {
        public User()
        {
            UserCourses = new HashSet<UserCourse>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? DataOfBirth { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
