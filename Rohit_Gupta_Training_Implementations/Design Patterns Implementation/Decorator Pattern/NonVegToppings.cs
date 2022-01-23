using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    internal class NonVegToppings : PizzaDecorator
    {
        public NonVegToppings(Pizza myPizza) : base(myPizza) { }

        public override int getCost()
        {
            return base.getCost() + 150;
        }

        public override string getDescription()
        {
            return base.getDescription() + " with Non-Veg Toppings";
        }
    }
}
