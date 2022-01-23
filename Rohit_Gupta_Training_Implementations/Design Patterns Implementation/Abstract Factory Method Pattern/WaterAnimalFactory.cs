using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Method_Pattern
{
    internal class WaterAnimalFactory : AbstractAnimalFactory
    {
        public override Animal getAnimal(String AnimalName)
        {
            switch (AnimalName)
            {

                case "Whale":
                    return new Whale();
                 

                case "Shark":
                    return new Shark();

            }
            return null;
        }
    }
}
