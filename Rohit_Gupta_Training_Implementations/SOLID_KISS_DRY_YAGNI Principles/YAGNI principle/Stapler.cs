using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SOLID_KISS_DRY_YAGNI_Principles.YAGNI_principle
{
    internal class Stapler
    {
        //Required Functionality
        public void staple()
        {
            Console.WriteLine("Inside Staple Method : I can Staple");
        }


        //Not Required Functionality
        public void flash() {

            Console.WriteLine("Inside Flash Method : Why Does a Stapler need to Flash light?");
        }
    }
}
