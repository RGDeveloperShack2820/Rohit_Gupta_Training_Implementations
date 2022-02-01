using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class SortedList_Implementation
    {
        public void execute()
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(0, "A");
            sl.Add(1, "B");
            sl.Add(2, "C");

            foreach (KeyValuePair<int, string> kvp in sl)
            {

                Console.WriteLine($"Key :{kvp.Key} | Value : {kvp.Value}");
            }
        }
    }
}
