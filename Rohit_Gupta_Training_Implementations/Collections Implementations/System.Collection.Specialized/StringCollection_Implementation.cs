using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collection.Specialized
{
    internal class StringCollection_Implementation
    {
        public void execute()
        {
            StringCollection sc = new StringCollection();

     
            sc.Add("A");
            sc.Add("B");
            sc.Add("C");
            sc.Add("D");
            sc.Add("E");

            foreach (string str in sc)
            {
                Console.WriteLine(str);
            }
        }
    }
}
