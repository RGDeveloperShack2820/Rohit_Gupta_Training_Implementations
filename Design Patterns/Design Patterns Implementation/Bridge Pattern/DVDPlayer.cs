using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    internal class DVDPlayer : Device
    {
        public void bwdButtonPressed()
        {
            Console.WriteLine("Seek Backward");
        }

        public void fwdButtonPressed()
        {
            Console.WriteLine("Seek Forward");
        }
    }
}
