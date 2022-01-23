using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    internal class Guard : Employee
    {
        string Name;
        int salary;
        string designation;
        public Guard(string Name, int salary)
        {
            this.Name = Name;
            this.salary = salary;
            this.designation = "Guard";
        }

        

        public override string getName()
        {
            return Name;
        }

        public override int getSalary()
        {
            return salary;
        }

        public override void printDetails()
        {
            Console.WriteLine($"Name: {Name} | Salary : {salary} | Designation : {designation}");
        }

      
    }
}
