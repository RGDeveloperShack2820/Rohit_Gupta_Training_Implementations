using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    internal abstract class AbstractPizza
    {
      public abstract string getDescription();
      public abstract int getCost();
    }
}
