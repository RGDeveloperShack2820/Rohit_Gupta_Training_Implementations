using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    internal abstract class Vehicle
    {
        protected string type;
        protected int noOfWheels;
        protected int weight;
        protected string paint;

       public abstract void setPaint(string paint);
    }
}
