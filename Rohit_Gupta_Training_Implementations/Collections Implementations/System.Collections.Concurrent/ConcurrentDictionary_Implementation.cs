using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Concurrent
{
    internal class ConcurrentDictionary_Implementation
    {
        public void execute()
        {
            ConcurrentDictionary<string, string> cdictionary = new ConcurrentDictionary<string, string>();
            cdictionary.TryAdd("1", "First");
            cdictionary.TryAdd("2", "Second");
            cdictionary.TryAdd("3", "Third");
            cdictionary.TryAdd("4", "Fourth");

            foreach (var item in cdictionary)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
        }
    }
}
