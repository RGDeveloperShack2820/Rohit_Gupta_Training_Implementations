using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_Of_Responsibility_Pattern
{
    internal interface Chain
    {
        public void setNextChain(Chain nextChain);
        public void performCalculation(Calculate data);
    }
}
