using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Concurrent
{
    internal class ConcurrentBag_Implementation
    {
        public void execute()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(1);
            bag.Add(2);

            foreach (var item in bag)
            {
                Console.WriteLine("item");
            }
        }
    }
}
