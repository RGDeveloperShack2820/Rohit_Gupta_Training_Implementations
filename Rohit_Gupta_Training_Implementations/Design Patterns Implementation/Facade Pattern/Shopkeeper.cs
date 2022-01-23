using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade_Pattern
{
    internal class Shopkeeper
    {
        Samsung galaxy;
        Apple iphone;

        public Shopkeeper()
        {
            this.galaxy = new Samsung();
            this.iphone = new Apple();
        }

        public void getApple()
        {
            iphone.getModel();
            iphone.getPrice();
        }

        public void getSamsung()
        {
            galaxy.getModel();
            galaxy.getPrice();  
        }
    }
}
