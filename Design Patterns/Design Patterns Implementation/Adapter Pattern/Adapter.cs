using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal class Adapter : Target
    {
        Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void getRequest()
        {
            adaptee.getSpecificRequest();
        }
    }
}
