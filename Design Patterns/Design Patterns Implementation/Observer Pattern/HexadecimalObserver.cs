using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Observer_Pattern
{
    internal class HexadecimalObserver : Observer
    {
        public HexadecimalObserver (Subjects subject)
        {
            this.subject = subject;
            this.subject.addObserver(this);
        }

        public override void update()
        {
            Console.WriteLine($"Hexadecimal Updated : {subject.getState().ToString("X")}");
        }
    }
}
