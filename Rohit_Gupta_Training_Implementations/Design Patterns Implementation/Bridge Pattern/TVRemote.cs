using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    internal class TVRemote : Remote
    {

        TVDevice tv;

        public TVRemote(TVDevice tv)
        {
            this.tv = tv;
        }

        public void bwdButtonPressed()
        {
            Console.Write("TV Remote Backward Button Pressed : ");
            tv.bwdButtonPressed();

        }

        public void fwdButtonPressed()
        {
            Console.Write("TV Remote Forward Button Pressed : ");
            tv.fwdButtonPressed();
        }
    }
}
