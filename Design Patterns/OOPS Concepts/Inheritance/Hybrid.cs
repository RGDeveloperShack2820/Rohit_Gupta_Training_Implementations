using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Inheritance
{
    class Stud
    {
        public void method1()
        {
            Console.WriteLine("Inside stud");
        }
    }

    class Marks : Stud
    {
        public void method2()
        {
            Console.WriteLine("Inside Marks");
        }
    }

    interface SportMarks
    {
        void method3();
    }

    class Result : Marks, SportMarks
    {
        public void method3()
        {
            Console.WriteLine("Inside Result method 3");
        }

        public void method4()
        {
            Console.WriteLine("Inside Result method 4");
        }
    }

    internal class Hybrid
    {
        public void execute()
        {
            Result result = new Result();
            result.method1();
            result.method2();
            result.method3();
            result.method4();   
        }
    }
}
