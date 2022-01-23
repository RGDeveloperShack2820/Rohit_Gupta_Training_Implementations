using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade_Pattern
{
    internal class Apple : SmartphoneInterface
    {
        public void getModel()
        {
            Console.Write("Iphone : ");
        }

        public void getPrice()
        {
            Console.WriteLine("Rs. 90,000");
        }
    }
}
