using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Visitor_Pattern
{
    internal class ComputerPartVisitor : Visitor
    {
        public void visit(KeyBoard keyBoard)
        {
            Console.WriteLine("Visiting Keyboard");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Visiting Mouse");
        }
    }
}
