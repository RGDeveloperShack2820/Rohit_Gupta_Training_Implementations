using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SOLID_Principles.Single_Responsibility_Principle
{
    internal class Sub : Calculator
    {
        int num1;
        int num2;

        public Sub(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int calculate()
        {
            return getNum1() - getNum2();
        }

        public int getNum1()
        {
            return num1;
        }

        public int getNum2()
        {
            return num2;
        }
    }
}
