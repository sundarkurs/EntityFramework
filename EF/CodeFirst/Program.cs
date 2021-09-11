using CodeFirst.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            UseUnit();

            Console.ReadLine();
        }

        public static void UseUnit()
        {
            using (var unitOfWork = new UnitOfWork(new UserManagementContext()))
            {
                // Example1
                var user = unitOfWork.Users.Get(1);

                //// Example2
                //var courses = unitOfWork.Courses.GetCoursesWithAuthors(1, 4);

                //// Example3
                //var author = unitOfWork.Authors.GetAuthorWithCourses(1);
                //unitOfWork.Courses.RemoveRange(author.Courses);
                //unitOfWork.Authors.Remove(author);
                //unitOfWork.Complete();
            }
        }

        public static void UseContext()
        {
            using (var context = new UserManagementContext())
            {
                var courses = context.UserCourses.Include(a => a.Course).Include(a => a.User);

                foreach (var course in courses)
                {
                    Console.WriteLine("{0} - {1}", course.Course.Name, course.User.Name);
                }
            }
        }
    }
}
