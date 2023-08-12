using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject;

namespace UniversityProject
{
    class Course
    {
       protected string courseName;
       protected int courseCode;
    


        public Course(string _courseName, int _courseCode)
        {
            this.courseName = _courseName;
            this.courseCode = _courseCode;
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {

                if (courseName.GetType() == typeof(string))
                {
                    courseName = value;
                }
                else { Console.WriteLine("Invalid"); }


            }
        }

        public int CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }

        
        public new string ToString()
        {
            return $"Course name : {courseName} Course Code : {courseCode}";
        }
     
    }

}
