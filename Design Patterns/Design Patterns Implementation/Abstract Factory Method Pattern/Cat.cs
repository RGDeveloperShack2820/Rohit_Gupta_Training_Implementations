using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Method_Pattern
{
    internal class Cat : Animal
    {

        public void makeSound()
        {
            Console.WriteLine("Cat Sound");
        }
    }
}
