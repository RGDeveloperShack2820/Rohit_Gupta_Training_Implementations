using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Liskov_s_Substitution_Principle
{
    internal class Cars
    {
        public virtual void drive() {

            Console.WriteLine("driving");
        
        }
    }
}
