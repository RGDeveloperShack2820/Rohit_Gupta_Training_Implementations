using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal class ProductA : ProductPlan
    {
        public void setPartA(string partA)
        {
            Console.WriteLine("Part A : "+partA);
        }

        public void setPartB(string partB)
        {
            Console.WriteLine("Part B : " + partB);
        }

        public void setPartC(string partC)
        {
            Console.WriteLine("Part C : " + partC);
        }

        public void setPartD(string partD)
        {
            Console.WriteLine("Part D : " + partD);

        }
    }
}
