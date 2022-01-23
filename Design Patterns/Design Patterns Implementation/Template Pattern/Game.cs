using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    internal abstract class Game
    {
        public abstract void start();
        public abstract void stop();
        public abstract void homeScreen();

        public void play()
        {
            homeScreen();
            start();
            stop(); 
        }

    }
}
