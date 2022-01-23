using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    internal class RoadRash : Game
    {
        public override void homeScreen()
        {
            Console.WriteLine("Welcome To Road-Rash");
        }

        public override void start()
        {
            Console.WriteLine("Road-Rash Started");
        }

        public override void stop()
        {
            Console.WriteLine("Road-Rash Stopped");
        }
    }
}
