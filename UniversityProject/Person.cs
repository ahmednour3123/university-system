using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject
{
    abstract class Person
    {
        protected string name;
        protected int age;

        public Person() : this(null, 0)
        { }
        public Person(string _name) : this(_name,0)
        {
            name = _name;
        }
        public Person(string _name, int _age)
        {
            name = _name;
            age = _age;
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
        public int Age { get; set; }
        public new string ToString()
        {
            return $" name is {name} Age is :{age}";
        }

    }
}
