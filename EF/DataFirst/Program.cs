using DataFirst.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Database.UserManagementEntities())
            {
                var courses = context.UserCourses;

                foreach (var course in courses)
                {
                    Console.WriteLine("{0} - {1}", course.Course.Name, course.User.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
