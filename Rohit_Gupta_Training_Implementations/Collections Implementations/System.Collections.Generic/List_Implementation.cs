using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Generic
{
    internal class List_Implementation
    {
        public void execute()
        {
            List<string> list = new List<string>();

            list.Add("Rohit");
            list.Add("Mohit");

            foreach (string item in list) {

                Console.WriteLine(item);
            }
        }
    }
}
