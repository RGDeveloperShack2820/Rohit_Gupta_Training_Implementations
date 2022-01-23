using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy_Pattern
{
    internal class RealLockerAccess : LockerAccessInterface
    {
        private String name;

        public RealLockerAccess(string name)
        {
            this.name = name;
        }

        public void grantAccess()
        {
            Console.WriteLine("Locker Access Granted");
        }
    }
}
