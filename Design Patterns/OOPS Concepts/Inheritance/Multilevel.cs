using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Inheritance
{
    class Animals
    {
        public void method1() { Console.WriteLine("Inside Animals"); }
    }

    class Mammels : Animals
    {
        public void method2() { Console.WriteLine("Inside Mammels"); }
    }

    class Humans : Mammels
    {
        public void method3() { Console.WriteLine("Inside Humans"); }
    }
    internal class Multilevel
    {
        public void execute()
        {
            Humans humans =new Humans();
            humans.method1();
            humans.method2();
        }
    }
}
