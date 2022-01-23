using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Constructors
{
    class A
    {
        static int i;
        static int j;

        static A()
        {
            i = 10;
            j = 20;

            Console.WriteLine($"Inside Static Constructor : i= {i} , j= {j}");
        }
    }
    internal class StaticConstructor
    {
        public void execute()
        {
            A a=new A();
        }
    }
}
