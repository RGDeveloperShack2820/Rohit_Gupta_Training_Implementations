using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Interface_Segregation_Princliple
{
    internal interface AutoPilotCar
    {
        void moveForward();
        void moveBackward();
        void moveLeft();
        void moveRight();
    }
}
