using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal class Adaptee
    {
        public void getSpecificRequest()
        {
            Console.WriteLine("Specific Request Generated");
        }
    }
}
