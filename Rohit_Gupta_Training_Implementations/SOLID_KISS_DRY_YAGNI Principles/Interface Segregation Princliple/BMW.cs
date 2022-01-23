using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Interface_Segregation_Princliple
{
    internal class BMW : AutoPilotCar
    {
        public void moveBackward()
        {
            Console.WriteLine("BMW moving forward");
        }

        public void moveForward()
        {
            Console.WriteLine("BMW moving backward");
        }

        public void moveLeft()
        {
            Console.WriteLine("BMW moving left");
        }

        public void moveRight()
        {
            Console.WriteLine("BMW moving right");
        }
    }
}
