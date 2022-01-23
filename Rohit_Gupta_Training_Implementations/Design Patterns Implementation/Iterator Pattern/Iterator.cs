using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Iterator_Pattern
{
    internal interface Iterator
    {
        public Boolean hasNext();
        public Object next();
    }
}
