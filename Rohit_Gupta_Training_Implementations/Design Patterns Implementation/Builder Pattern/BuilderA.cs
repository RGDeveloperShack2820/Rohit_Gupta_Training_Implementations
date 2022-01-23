using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal class BuilderA : AbstractBuilder
    {
        ProductA product;

        public BuilderA()
        {
            this.product = new ProductA();
        }

        public void buildParts()
        {
            product.setPartA("Title");
            product.setPartB("Head");
            product.setPartC("Body");
            product.setPartD("Footer");
        }

        public ProductA getProduct()
        {
            return product;
        }
    }
}
