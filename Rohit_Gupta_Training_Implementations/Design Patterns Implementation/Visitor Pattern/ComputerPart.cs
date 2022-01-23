using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Visitor_Pattern
{
    internal interface ComputerPart
    {
        public void accept(Visitor computerPartVisitor);
    }
}
