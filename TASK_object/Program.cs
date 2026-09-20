using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_object
{

    class Person
    {
        class person
        {
            public string name;
            public int age;
            public string course { get; set; }

            public person(string name, int age)
            {
                this.name = name;
                this.age = age;
                course = course;
            }
            public void Display()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Course: " + course);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                person p1 = new person("john", 20);
                p1.course = "C#";
                p1.Display();
            }
        }
    }
}
