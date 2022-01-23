using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Design_Patterns_Implementation.Strategy_Pattern
{
    internal class Painting : Repair
    {
        public void customize(Scooter scooter)
        {
            scooter.setPaint("Yellow");
        }
    }
}
