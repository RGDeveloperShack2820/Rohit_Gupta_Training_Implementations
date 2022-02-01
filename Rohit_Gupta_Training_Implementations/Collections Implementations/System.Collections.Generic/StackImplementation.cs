using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class StackImplementation
    {
        public void execute()
        {
            Stack<int> stck = new Stack<int>();

            stck.Push(1);
            stck.Push(2);
            stck.Push(3);

            foreach (int i in stck)
            {
                Console.WriteLine(i);
            }


        }
    }
}
