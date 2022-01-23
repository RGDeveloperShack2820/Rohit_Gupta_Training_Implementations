using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Inheritance
{
    class animal
    {
        public void method1() { Console.WriteLine("Inside Animal"); }
    }

    class Lion : animal
    {
        public void method2() { Console.WriteLine("Inside Lion"); }
    }
    internal class Single_Level_Inheritance
    {
        public void execute (){
        
            Lion lion = new Lion();
            lion.method1();
        
        }
    }
}
