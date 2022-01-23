using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Aggregation
{
    internal class Teacher
    {
        List<Students> _students = new List<Students>();
        private string  name;
        private int salary;

        public Teacher(string name, int salary)
        {
           
            this.name = name;
            this.salary = salary;
        }

        public string getName() { return name; }
        public int getSalary() { return salary; }

        public void getStudents()
        {
            Console.WriteLine("Students Under "+this.name);
            foreach (Students student in _students) { Console.WriteLine(student.getName()); }
        }

        public void addStudent(Students students)
        {
            if (!_students.Contains(students))
            {
                _students.Add(students);
            }
        }
    }
}
