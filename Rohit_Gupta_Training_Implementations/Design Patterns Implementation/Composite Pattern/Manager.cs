using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    internal class Manager : Employee
    {
        List<Employee> _employees=new List<Employee>();
        string Name;
        int salary;
        string designation;

        public Manager(string Name, int salary)
        {
            this.Name = Name;
            this.salary = salary;
            this.designation = "Manager";
        }

        public override void addEmployee(Employee employee)
        {
            if (!_employees.Contains(employee))
            {
                _employees.Add(employee);
                Console.WriteLine($"{employee.getName()} added under {Name}");
            }
        }

        public override string getName()
        {
            return this.Name;
        }

        public override int getSalary()
        {
            return this.salary;
        }

        public override void printDetails()
        {
            Console.WriteLine($"Name: {Name} | Salary : {salary} | Designation : {designation}");
            
            if(_employees.Count > 0)
            {
                Console.WriteLine("Employees Under "+Name+":");
                foreach(Employee emp in _employees)
                    emp.printDetails();
            }
        }

        public override void removeEmployee(Employee employee)
        {
            if (_employees.Contains(employee))
            {
                Console.WriteLine($"{employee.getName()} removed from {Name}'s employees");
                _employees.Remove(employee);
            }
        }

    }
}
