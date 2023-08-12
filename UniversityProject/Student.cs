using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using UniversityProject;

namespace UniversityProject
{

    class Student : Person
    {
        public static int student_id;


        public List<Course> StudentCourses = new List<Course>().ToList();

        public Student(string _name, int _age)
        {
            GenerateID();
            this.name = _name;
            this.age = _age;
        }

        public static int GenerateID()
        {
            return ++student_id;
        }

        public int returnStudentID()
        {
            return student_id;
        }


        public void RegisterCourse()
        {
            List<Course> tempList = CourseManager.returnCourses();
            Console.WriteLine("Enter The Course Code You Want To Take : ");
            int inputCode = int.Parse(Console.ReadLine());
            foreach (Course item in tempList)
            {
                if (item.CourseCode == inputCode)
                {
                    Console.WriteLine($"Signing Up For {item.CourseName}");
                    Course studentCourse = new Course(item.CourseName, item.CourseCode);
                    StudentCourses.Add(studentCourse);
                }

            }
        }
        public void ViewStudentCourses()
        {
            if (StudentCourses.Any())
            {
                foreach (Course item in StudentCourses)
                {
                    Console.WriteLine($"{this.name} is signed up for : " + item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Courses List is Empty");
            }
        }

    }
}
