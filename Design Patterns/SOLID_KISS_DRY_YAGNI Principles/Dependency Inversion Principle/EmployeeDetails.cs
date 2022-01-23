using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Dependency_Inversion_Principle
{
    internal class EmployeeDetails
    {
        SalaryInterface salary;

        int hoursWorked;
        int hourlyRate;

        public EmployeeDetails(int hoursWorked, int hourlyRate,SalaryInterface salary)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
            this.salary = salary;   
        }

        public void getSalary()
        {
            salary.CalculateSalary(hoursWorked, hourlyRate);
        }
    }
}
