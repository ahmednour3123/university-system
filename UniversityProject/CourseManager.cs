using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityProject;

namespace UniversityProject
{
    static class CourseManager
    {
        public static List<Course> CourseList = new List<Course>().ToList();


        public static void ViewCourses()
        {
      
            if (CourseList.Any())
            {
                foreach (Course item in CourseList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Courses List is Empty");
            }
        }
        public static List<Course> returnCourses()
        {
            return CourseList;
        }
    }
}
