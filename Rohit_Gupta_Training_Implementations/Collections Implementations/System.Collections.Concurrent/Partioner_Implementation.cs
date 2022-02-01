using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.System.Collections.Concurrent
{
    internal class Partioner_Implementation
    {
        public void execute()
        {
            var source = Enumerable.Range(0, 100000).ToArray();
            var rangePartitioner = Partitioner.Create(0, source.Length);
            double[] results = new double[source.Length];
            Parallel.ForEach(rangePartitioner, (range, loopState) =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    results[i] = source[i] * Math.PI;
                }
            });
            Console.WriteLine("Operation complete. Print results? y/n");
            char input = Console.ReadKey().KeyChar;
            if (input == 'y' || input == 'Y')
            {
                foreach (double d in results)
                {
                    Console.Write("{0} ", d);
                }
            }
        }
    }
}
