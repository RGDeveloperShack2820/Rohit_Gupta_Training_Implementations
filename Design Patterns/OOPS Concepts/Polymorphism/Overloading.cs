using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Polymorphism
{
    class Beings { }
    class Monkey : Beings { }

    internal class Overloading
    {
       
            public void methodone(int i)
            {
                Console.WriteLine("Integer method");
            }

            public void methodone(double i)
            {
                Console.WriteLine("double method");
            }

            public void methodone(Object i)
            {
                Console.WriteLine("object method");
            }

            public void methodone(String i)
            {
                Console.WriteLine("string method");
            }

            public void methodone(float i, int j)
            {
                Console.WriteLine("float-int method");
            }

            public void methodone(Beings beings,Boolean boolean)
            {
                Console.WriteLine("Beings method");
            }

            public void methodone(Monkey monkey, Boolean boolean)
            {
                Console.WriteLine("monkey method");
            }

        public void execute()
        {
            Overloading overloading = new Overloading();
            overloading.methodone(10);
            overloading.methodone(20.5);
            overloading.methodone(null);
            overloading.methodone(10.5f, 100);
            overloading.methodone(200, 200);

            Beings a = new Beings();
            overloading.methodone(a,true);
            Monkey m=new Monkey();
            overloading.methodone(m,true);
            Beings a1=new Monkey(); 
            overloading.methodone(a1,true);

        }
    }
}
