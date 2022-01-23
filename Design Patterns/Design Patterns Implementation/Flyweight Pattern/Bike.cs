using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    internal class Bike : Vehicle
    {
        public Bike()
        {
            type = "Bike";
            noOfWheels = 2;
            weight = 150;

        }

        public override void setPaint(string paint)
        {
            this.paint = paint;
            Console.WriteLine($"A {paint} {type} with {noOfWheels} wheels weighs {weight} kg.");
        }
    }
}
