using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_Of_Responsibility_Pattern
{
    internal class Calculate
    {
        private int number1;
        private int number2;
        private string calculation;

        public Calculate(int number1, int number2, string calculation)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.calculation = calculation;
        }

        public int getNumber1() { return number1; }
        public int getNumber2() { return number2; }
        public string getCalculation() { return calculation; }

       

    }
}
