using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Iterator_Pattern
{
    internal class CollectionOfNames : Iterator
    {
        public string[] names = { "Rohit", "Raj", "Shyam", "Mohan" };
        public int i;
        public bool hasNext()
        {
            if (i < names.Count())
            {
                return true;
            }
            return false;
        }

        public object next()
        {
            if (this.hasNext())
            {
                return names[i++];
            }
            return null;
        }
    }
}
