using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Dependency_Inversion_Principle
{
    internal class SalaryCalculator : SalaryInterface
    {
        public void CalculateSalary(int hoursWorked, float hourlyRate)
        {
            Console.WriteLine("Salary= "+(hourlyRate*hoursWorked));
        }
    }
}
