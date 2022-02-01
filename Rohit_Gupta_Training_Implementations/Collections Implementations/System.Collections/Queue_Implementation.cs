using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections
{
    internal class Queue_Implementation
    {
        public void execute()
        {
            Queue<int> q = new Queue<int>();

            q.Append(1);
            q.Append(2);
            q.Append(3);
            

            foreach (int i in q)
            {
                Console.WriteLine(i);
            }


        }
    }
}
