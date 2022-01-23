using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    internal class DVDRemote : Remote
    {
        DVDPlayer player;

        public DVDRemote(DVDPlayer player)
        {
            this.player = player;
        }

        public void bwdButtonPressed()
        {
            Console.Write("DVD Remote Backward Button Pressed : ");
            player.bwdButtonPressed();

        }

        public void fwdButtonPressed()
        {
            Console.Write("DVD Remote Forward Button Pressed : ");
            player.fwdButtonPressed();
        }
    }
}
