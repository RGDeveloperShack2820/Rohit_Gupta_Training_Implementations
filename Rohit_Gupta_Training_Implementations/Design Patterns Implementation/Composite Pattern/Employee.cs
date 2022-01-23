using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    internal abstract class Employee
    {

        public abstract string  getName();
        public abstract int getSalary();
        public abstract void printDetails();

        public virtual void addEmployee(Employee employee) { Console.WriteLine(this.getName()+" is Not Authorised to add Employees\n"); }

        public virtual void removeEmployee(Employee employee) { Console.WriteLine(this.getName() + " is Not Authorised to remove Employee\n"); }
    }
}
