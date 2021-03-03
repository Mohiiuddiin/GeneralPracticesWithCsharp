using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Course> courses = new List<Course>();
            
            Course course1 = new Course();
            course1.Code = "CSE-101";
            course1.Title = "Computer Fundamental";
            course1.Credit = 3;

            Course course2 = new Course();
            course2.Code = "CSE-102";
            course2.Title = "Computer Programming";
            course2.Credit = 3;


            Department department = new Department();
            department.Code = "CSE";
            department.Name = "Computer Science And Engineering";
            department.Courses.Add(course1);
            department.Courses.Add(course2);


            foreach (Course course in department.Courses )
            {
                Console.WriteLine(course.Title);
            }


        }
    }
}
