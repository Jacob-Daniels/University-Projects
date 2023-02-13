using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    public class Student
    {
        // Attributes
        string name;
        int age;

        // Constructor
        public Student(string name, int age) { this.name = name; this.age = age; }

        // Methods
        public int Age { get { return age; } }
        public string Name { get { return name; } }

    }
}
