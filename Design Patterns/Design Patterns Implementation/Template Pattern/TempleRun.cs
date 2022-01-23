using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    internal class TempleRun : Game
    {
        public override void homeScreen()
        {
            Console.WriteLine("Welcome To Temple Run");
        }

        public override void start()
        {
            Console.WriteLine("Temple Run Started");
        }

        public override void stop()
        {
            Console.WriteLine("Temple Run Stopped");
        }
    }
}
