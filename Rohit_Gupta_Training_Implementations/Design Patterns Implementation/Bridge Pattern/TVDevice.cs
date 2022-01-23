using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    internal class TVDevice : Device
    {
        public void bwdButtonPressed()
        {
            Console.WriteLine("Channel Down");
        }

        public void fwdButtonPressed()
        {
            Console.WriteLine("Channel UP");
        }
    }
}
