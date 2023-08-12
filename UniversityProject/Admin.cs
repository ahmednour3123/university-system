using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using UniversityProject;

namespace UniversityProject
{
    class Admin
    {

        protected static int admin_id;
        protected string name;
        protected List<TeachersWithCourses> teachersWithCoursesList = new List<TeachersWithCourses>().ToList();

        public Admin(string name)
        {
            GenerateID();
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name.GetType() == typeof(string))
                {
                    Console.WriteLine("String");
                }
                else
                {
                    Console.WriteLine("Not String");

                }
            }
        }

        public int GenerateID()
        {
            return ++admin_id;
        }

        #region Teacher Functions
        public Teacher AddTeacher(string _teacherName, int _teacherAge)
        {
            Teacher teacher = new Teacher(_teacherName, _teacherAge);
            Teacher.TeacherList.Add(teacher);
            return teacher;
        }
        public void AddTeacherToCourse(Teacher _teacher, Course _course)
        {
            TeachersWithCourses obj = new TeachersWithCourses(_teacher, _course);
            teachersWithCoursesList.Add(obj);
        }
        public void ViewTeacherToCourse()
        {
            if (teachersWithCoursesList.Any())
            {
                foreach (TeachersWithCourses item in teachersWithCoursesList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public void ViewTeachers()
        {
            //If The CourseList isn't Empty.
            if (Teacher.TeacherList.Any())
            {
                foreach (Teacher item in Teacher.TeacherList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Teacher List is Empty");
            }
        }
        public void DeleteTeacher(int _teacherID)
        {
            foreach (Teacher item in Teacher.TeacherList)
            {
                //Get The Teacher ID
               
                if (item.returnTeacherID() == _teacherID)
                {
                    Teacher.TeacherList.Remove(item);
                    return;
                }
            }
        }
        #endregion
        #region Courses Function
        public Course AddCourse(string _courseName, int _courseCode)
        {
            Course course = new Course(_courseName, _courseCode);
            CourseManager.CourseList.Add(course);
            return course;
        }
        public void DeleteCourse(int courseCode)
        {
            foreach (Course item in CourseManager.CourseList)
            {
                if (item.CourseCode == courseCode)
                {
                    CourseManager.CourseList.Remove(item);
                    return;
                }
            }
        }
        #endregion
        public new string ToString()
        {
            return $"Admin -> ID : {admin_id}, Name : {name}";
        }
    }
}
