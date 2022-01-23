using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Interface_Segregation_Princliple
{
    internal class BulletTrain : AutoPilotTrain
    {
        public void moveBackward()
        {
            Console.WriteLine("Bullet train moving backward");
        }

        public void moveForward()
        {
            Console.WriteLine("Bullet train moving forward");
        }
    }
}
