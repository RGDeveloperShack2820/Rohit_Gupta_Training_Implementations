using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Constructors
{

    class Print
    {
        public Print(double i)
        {
            Console.WriteLine("Inside Double Constructor : "+i);
        }

        public Print(int i)
        {
            Console.WriteLine("Inside integer Constructor : "+i);
        }

    }
    internal class ParameterizedConstructor
    {
       
        public void execute()
        {
            Print print = new Print(10);
            Print print1 = new Print(10.5);
        }
    }
}
