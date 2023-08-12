using System;
namespace UniversityProject
{
    class Program
    {
        static void ExistingCourses()
        {
            Admin admin = new Admin("Ahmed");
            admin.AddCourse("OOP", 104);
            admin.AddCourse("html",106);
            admin.AddCourse("css", 108);
            admin.AddCourse("Rect", 110);
            admin.AddCourse("js", 112);
        }
        static void Main(string[] args)
        {
            ////Teachers with Courses List
            Admin admin = new Admin("Ramez");
            Console.WriteLine(admin.ToString());
            Course course = admin.AddCourse("React", 102);
            Teacher teacher = admin.AddTeacher("Ramez", 23);

            admin.AddTeacherToCourse(teacher, course);
            admin.ViewTeacherToCourse();
         
            ExistingCourses();
            Console.WriteLine("Available Courses :\n --------------------------------------");
            CourseManager.ViewCourses();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Welcome are you Admin or Student? \n 1 - Admin \n 2 - Student");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Admin admin1 = new Admin(name);
            Console.Write("Enter Your Age :");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student(name, age);

            while (true)
            {
                if (input == 1)
                {
            Console.WriteLine($"Hello Admin {admin1.Name} what would you like to do? \n 1 - Add Course \n 2 - view course \n 3 - Delete Course");

                    int a = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        if (a == 1)
                        {
                            Console.WriteLine("enter course name and course code: ");
                            string b = Console.ReadLine();
                            int c = int.Parse(Console.ReadLine());
                            admin.AddCourse(b, c);
                            break;

                        }
                        else if (a == 2)
                        {
                            CourseManager.ViewCourses();
                            break;
                        }
                        else if (a == 3)
                        {
                            Console.WriteLine("Enter Course Code You Want Delete: ");
                            int d = int.Parse(Console.ReadLine());
                            admin.DeleteCourse(d);
                            break;
                        }
                    }

                }
                else if (input == 2)
                {
                    
                    Console.WriteLine($"Hello student {student.Name} what would like to do? \n 1 - Register Course \n 2 - View Student Courses");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        student.RegisterCourse();
                      
                    }
                    else if (x == 2)
                    {
                        student.ViewStudentCourses();

                    }
                }
            }
        }
     
    }

}
