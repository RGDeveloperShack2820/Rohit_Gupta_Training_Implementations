using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal interface ProductPlan
    {
        void setPartA(String partA);
        void setPartB(String partB);
        void setPartC(String partC);
        void setPartD(String partD);
    }
}
