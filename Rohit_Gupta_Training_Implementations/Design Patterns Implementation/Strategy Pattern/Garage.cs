using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Design_Patterns_Implementation.Strategy_Pattern
{
    internal class Garage
    {
        Repair repair;

        public Garage(Repair repair)
        {
            this.repair = repair;
        }

        public void start(Scooter scooter)
        {
            repair.customize(scooter);
        }
    }
}
