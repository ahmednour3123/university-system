using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UniversityProject;

namespace UniversityProject
{
    class Teacher : Person
    {
        public static int teacher_id;

        public static List<Teacher> TeacherList = new List<Teacher>().ToList();


        public Teacher(string _name, int _age)
        {
            GenerateID();
            this.name = _name;
            this.age = _age;

        }
        public string teacherName { get { return name; } }
        public int teacherAge { get { return age; } }

        public static int GenerateID()
        {
            return ++teacher_id;
        }

        public int returnTeacherID()
        {
            //delete teacher by id
            return teacher_id;
        }

     
        public new string ToString()
        {
            return $"Teacher -> ID : {teacher_id}, Name : {name}";
        }

    }
}