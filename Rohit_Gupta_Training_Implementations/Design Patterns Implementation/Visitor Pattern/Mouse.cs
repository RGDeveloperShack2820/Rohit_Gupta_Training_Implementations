using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Visitor_Pattern
{
    internal class Mouse : ComputerPart
    {
        public void accept(Visitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
