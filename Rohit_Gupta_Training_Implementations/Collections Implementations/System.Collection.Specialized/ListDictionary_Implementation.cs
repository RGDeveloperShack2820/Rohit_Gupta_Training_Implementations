using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collection.Specialized
{
    internal class ListDictionary_Implementation
    {
        public void execute()
        {
            ListDictionary listDictionary = new ListDictionary();

            listDictionary.Add("Rohit", 50);
            listDictionary.Add("Rajesh", 80);
            listDictionary.Add("Mohan", 95);
            listDictionary.Add("Bhuvan", 90);
            listDictionary.Add("Komal", 49);

            foreach (string key in listDictionary.Keys)
            {
                Console.WriteLine($"Name : {key} | Marks : {listDictionary[key]}");
            }

        }
    }
}
