using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Concurrent
{
    internal class ConcurrentQueue_Implementation
    {
        public void execute()
        {
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();

            cq.Append(1);
            cq.Append(2);
            cq.Append(3);


            foreach (int i in cq)
            {
                Console.WriteLine(i);
            }


        }
    }
}
