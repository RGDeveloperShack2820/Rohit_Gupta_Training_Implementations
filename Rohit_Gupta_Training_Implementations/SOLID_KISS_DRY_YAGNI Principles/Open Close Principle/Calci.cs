using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Open_Close_Principle
{
    internal interface Calci
    {
        int getNum1();
        int getNum2();

        int calculate();
    }
}
