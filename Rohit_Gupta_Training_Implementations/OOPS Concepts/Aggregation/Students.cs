using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Aggregation
{
    internal class Students
    {
        private string name;
        private int age;
        private int Marks;

        public Students(string name, int age, int marks)
        {
            this.name = name;
            this.age = age;
            Marks = marks;
        }

        public string getName() { return name; }
        public int getAge() { return age; } 

        public int getMarks() { return Marks; }
    }
}
