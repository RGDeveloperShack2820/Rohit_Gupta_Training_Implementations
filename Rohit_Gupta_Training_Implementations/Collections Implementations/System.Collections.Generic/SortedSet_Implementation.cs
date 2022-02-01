using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class SortedSet_Implementation
    {
        public void execute()
        {
            SortedSet<int> ss = new SortedSet<int>();

            
            ss.Add(2);
            ss.Add(0);
            ss.Add(1);


            foreach (int i in ss)
            {

                Console.WriteLine(i);
            }
        }
    }
}
