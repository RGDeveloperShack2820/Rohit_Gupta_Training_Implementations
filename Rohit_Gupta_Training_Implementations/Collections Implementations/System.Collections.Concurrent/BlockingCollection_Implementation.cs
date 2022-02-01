using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Concurrent
{
    internal class BlockingCollection_Implementation
    {
        public void execute()
        {
            BlockingCollection<int> bCollection = new BlockingCollection<int>(boundedCapacity: 2);
            bCollection.Add(1);
            bCollection.Add(2);
            bCollection.Add(3);

            foreach (int i in bCollection)
            {
                Console.WriteLine(i);
            }


        }
    }
}
