using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class LinkedList_Implementation
    {
        public void execute()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            

            foreach (int i in ll)
            {
                Console.WriteLine(i);
            }


        }
    }
}
