using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject
{
    class TeachersWithCourses
    {
        public Teacher teacher;
        public Course course;

        public TeachersWithCourses(Teacher teacher, Course course)
        {
            this.teacher = teacher;
            this.course = course;
        }
        public new string ToString()
        {
            return $"Teacher : {teacher.teacherName} teaches {course.CourseName} with code {course.CourseCode}";
        }


    }
}
