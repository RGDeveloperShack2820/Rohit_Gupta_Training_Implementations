using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class HashSet_Implementation
    {
        public void execute()
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(0);
            hs.Add(1);
            hs.Add(2);
            hs.Add(2);

            foreach (int i in hs)
            {

                Console.WriteLine(i);
            }
        }
    }
}
