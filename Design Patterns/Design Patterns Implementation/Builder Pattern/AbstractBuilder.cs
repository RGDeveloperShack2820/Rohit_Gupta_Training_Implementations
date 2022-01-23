using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal interface AbstractBuilder
    {
        void buildParts();
        ProductA getProduct();
    }
}
