using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Constructors
{
    class MyClass
    {
       static MyClass myClass=null;
        private MyClass()
        {
            Console.WriteLine("Inside Private Constructor");
        }

        
      public static MyClass getInstance()
            {
                if (myClass == null)
                    return new MyClass();
                else
                    return myClass;
            }
        
    }
    internal class PrivateConstructor
    {
        public void execute()
        {
           
            MyClass myClass= MyClass.getInstance();
        }
    }
}
