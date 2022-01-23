using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    internal class Pizza : AbstractPizza
    {
        public override int getCost()
        {
            return 100;
        }

        public override string getDescription()
        {
            return "Pizza";
        }
    }
}
