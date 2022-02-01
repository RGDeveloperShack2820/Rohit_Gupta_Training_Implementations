using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections
{
    internal class ArrayListImplementation
    {
        public void execute()
        {
            ArrayList al=new ArrayList();

            al.Add(1);
            al.Add(2);

            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}
