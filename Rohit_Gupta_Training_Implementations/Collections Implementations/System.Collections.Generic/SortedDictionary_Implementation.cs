using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class SortedDictionary_Implementation
    {
        public void execute()
        {
            SortedDictionary<int, string> sdc = new SortedDictionary<int, string>();

            sdc.Add(2, "C");
            sdc.Add(1, "B");
            sdc.Add(0, "A");
            

            foreach (KeyValuePair<int, string> kvp in sdc)
            {

                Console.WriteLine($"Key :{kvp.Key} | Value : {kvp.Value}");
            }
        }
    }
}
