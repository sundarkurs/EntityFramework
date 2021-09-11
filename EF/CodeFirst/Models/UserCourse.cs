using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirst.Models
{
    public partial class UserCourse
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
