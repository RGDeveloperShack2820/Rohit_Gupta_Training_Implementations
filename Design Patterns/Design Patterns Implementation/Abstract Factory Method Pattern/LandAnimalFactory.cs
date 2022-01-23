using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Method_Pattern
{
    internal class LandAnimalFactory : AbstractAnimalFactory
    {
        public override Animal getAnimal(String AnimalName)
        {
            switch (AnimalName) {

                case "Dog":
                    return new Dog();
                    

                case "Cat":
                    return new Cat();
            
            }
            return null;
        }

      
    }
}
