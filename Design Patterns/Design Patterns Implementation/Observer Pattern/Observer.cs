using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Observer_Pattern
{
    internal abstract class Observer
    {
        public Subjects subject;

        public abstract void update();

    }
}
