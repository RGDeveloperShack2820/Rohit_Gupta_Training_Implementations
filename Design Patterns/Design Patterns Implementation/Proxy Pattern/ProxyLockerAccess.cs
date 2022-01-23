using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy_Pattern
{
    internal class ProxyLockerAccess : LockerAccessInterface
    {
        RealLockerAccess lockeraccess=null;
        private String name;

        public ProxyLockerAccess(string name)
        {
            this.name = name;
        }

        public void grantAccess()
        {
            if (name == "Rohit")
            {
                lockeraccess = new RealLockerAccess(name);
                lockeraccess.grantAccess();
            }
            else
                Console.WriteLine("Access Denied");
        }
    }
}
