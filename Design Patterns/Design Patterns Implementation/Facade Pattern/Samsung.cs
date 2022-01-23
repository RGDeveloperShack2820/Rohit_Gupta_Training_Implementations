using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade_Pattern
{
    internal class Samsung : SmartphoneInterface
    {
        public void getModel()
        {
            Console.Write("Galaxy : ");
        }

        public void getPrice()
        {
            Console.WriteLine("Rs. 50,000");
        }
    }
}
