using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW4
    {
      public  static void Power(int a, int b)
        {
            Console.WriteLine($"{a}^{b}={Math.Pow(a, b)}");
        }
        class Student
        {
            string StudentId { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
            DateTime DateOfBirth { get; set; }
            string Address { get; set; }
            string Email { get; set; }
            string Phone { get; set; }
        }

        class Course
        {
            int CourseId { get; set; }
            string CourseName { get; set; }
            string Credits { get; set; }
            string Department { get; set; }
        }

        class Instructor
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Email { get; set; }
            string Phone { get; set; }
        }
    }
}
