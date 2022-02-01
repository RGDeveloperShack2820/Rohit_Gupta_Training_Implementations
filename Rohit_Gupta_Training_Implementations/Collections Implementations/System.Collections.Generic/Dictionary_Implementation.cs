using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class Dictionary_Implementation
    {
        public void execute()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();

            dc.Add(0, "A");
            dc.Add(1, "B");
            dc.Add(2, "C");

            foreach (KeyValuePair<int, string> kvp in dc)
            {
            
                Console.WriteLine($"Key :{kvp.Key} | Value : {kvp.Value}");
            }
        }
    }
}
