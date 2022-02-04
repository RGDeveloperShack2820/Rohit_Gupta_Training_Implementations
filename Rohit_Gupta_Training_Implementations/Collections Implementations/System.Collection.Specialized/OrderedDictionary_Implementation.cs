using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collection.Specialized
{
    internal class OrderedDictionary_Implementation
    {
        public void execute()
        {
            OrderedDictionary od = new OrderedDictionary();

            od.Add("Rohit", 50);
            od.Add("Rajesh", 80);
            od.Add("Mohan", 95);
            od.Add("Bhuvan", 90);
            od.Add("Komal", 49);


            IDictionaryEnumerator dictionaryEnumerator = od.GetEnumerator();

            while (dictionaryEnumerator.MoveNext())
            {
                Console.WriteLine($"Name : {dictionaryEnumerator.Key} | Marks : {od[dictionaryEnumerator.Key]}");
            }

        }
    }
}
