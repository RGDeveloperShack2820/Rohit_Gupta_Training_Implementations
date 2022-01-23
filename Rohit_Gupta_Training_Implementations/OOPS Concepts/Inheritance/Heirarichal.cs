using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Inheritance
{
    class Stationary
    {
        public void method1()
        {
            Console.WriteLine("Inside Stationary");
        }
    }

    class Paper : Stationary
    {
        void method2() { Console.WriteLine("Inside Paper"); }
    }

    class Pencil : Stationary
    {
        void method3() { Console.WriteLine("Inside Pencil"); }
    }
    internal class Heirarichal
    {
        public void execute()
        {
            Paper p = new Paper();
            Pencil pencil = new Pencil();
            p.method1();
            pencil.method1();
        }
    }
}
