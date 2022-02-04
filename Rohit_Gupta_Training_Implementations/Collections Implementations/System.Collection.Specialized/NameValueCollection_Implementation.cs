using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collection.Specialized
{
    internal class NameValueCollection_Implementation
    {
        public void execute()
        {
            NameValueCollection nvc = new NameValueCollection();

            nvc.Add("Phone", "Signal : Full");
            nvc.Add("Phone", "Battery : 100");
            nvc.Add("TV", "Screen : QHD");
            nvc.Add("TV", "Type : Flat Screen");
            nvc.Add("Phone", "Price : Rs. 20000");
            nvc.Add("Tv", "Price : Rs. 70000");
            

            foreach (string key in nvc)
            {
                Console.WriteLine($"Device : {key} | Attributes : {nvc[key]}");
            }
        }
    }
}
