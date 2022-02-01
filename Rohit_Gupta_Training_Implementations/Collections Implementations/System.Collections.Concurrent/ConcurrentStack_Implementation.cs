using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Concurrent
{
    internal class ConcurrentStack_Implementation
    {
        public void execute()
        {
            ConcurrentStack<int> s = new ConcurrentStack<int>();

            s.Push(50);
            s.Push(100);
            s.Push(150);
            s.Push(200);
            s.Push(250);
            s.Push(300);

           foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
