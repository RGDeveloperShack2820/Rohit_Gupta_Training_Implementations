using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    internal class Rikshaw : Vehicle
    {
        public Rikshaw()
        {
            type = "Rikshaw";
            noOfWheels = 3;
            weight = 200;

        }

        public override void setPaint(string paint)
        {
            this.paint = paint;
            Console.WriteLine($"A {paint} {type} with {noOfWheels} wheels weighs {weight} kg.");
        }
    }
}
