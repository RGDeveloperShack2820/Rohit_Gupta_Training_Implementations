using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal class Director
    {
        AbstractBuilder builder;

        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public ProductA getProduct()
        {
            return builder.getProduct();
        }

        public void buildProduct() {
        
            builder.buildParts();
        }
    }
}
