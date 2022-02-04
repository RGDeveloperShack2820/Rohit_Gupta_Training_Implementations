using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collection.Specialized
{
    internal class StringDictionary_Implementation
    {
        public void execute()
        {
            StringDictionary sd = new StringDictionary();

            sd.Add("A", "Apple");
            sd.Add("B", "Banana");
            sd.Add("C", "Cat");
            sd.Add("D", "Dog");
            sd.Add("E", "Elephant");

            foreach (DictionaryEntry dict in sd)
            {
                Console.WriteLine(dict.Key + " " + dict.Value);
            }
        }
    }
}
