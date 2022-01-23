using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Inheritance
{
    class Omnivorus
    {
        public void method1()
        {
            Console.WriteLine("Inside Omnivorus");
        }
    }

    interface Mammel
    {
        void method2();
    }

    class Human : Omnivorus, Mammel
    {
        public void method2()
        {
            Console.WriteLine("Inside Human");
        }
    }

    internal class Multiple
    {
        public void execute()
        {
            Human human = new Human();
            human.method1();
            human.method2();
        }
    }
}
