using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Method_Pattern
{
    internal class AnimalFactoryMaker
    {
       public static AbstractAnimalFactory getAbstractFactory(String type) {

            if (type == "Land")
            return new LandAnimalFactory();
            else if(type =="Water")
            return new WaterAnimalFactory();


            return null;
        }
    }
}
