using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SOLID_Principles.Single_Responsibility_Principle
{
    internal interface Calculator
    {
        int getNum1();
        int getNum2();

        int calculate();
    }
}
