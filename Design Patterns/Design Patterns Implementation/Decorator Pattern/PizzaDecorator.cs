using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    internal abstract class PizzaDecorator : AbstractPizza
    {
        Pizza myPizza;

        public PizzaDecorator(Pizza myPizza)
        {
            this.myPizza = myPizza;
        }

        public override int getCost()
        {
            return myPizza.getCost();
        }

        public override string getDescription()
        {
            return myPizza.getDescription();
        }
    }
}
