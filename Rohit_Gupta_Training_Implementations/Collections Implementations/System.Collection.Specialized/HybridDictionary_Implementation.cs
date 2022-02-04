using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collection.Specialized
{
    internal class HybridDictionary_Implementation
    {
        public void execute()
        {
            HybridDictionary hybridDictionary = new HybridDictionary();
           
            hybridDictionary.Add("Rohit", 50);
            hybridDictionary.Add("Rajesh", 80);
            hybridDictionary.Add("Mohan", 95);
            hybridDictionary.Add("Bhuvan", 90);
            hybridDictionary.Add("Komal", 49);
            hybridDictionary.Add("Hardik", 20);
            hybridDictionary.Add("Lokesh", 54);
            hybridDictionary.Add("Shyam", 09);
            hybridDictionary.Add("Boni", 100);
            hybridDictionary.Add("Tony", 65);
            hybridDictionary.Add("Casie", 23);

            foreach (string key in hybridDictionary.Keys)
            {
                Console.WriteLine($"Name : {key} | Marks : {hybridDictionary[key]}");
            }
        }
    }
}
