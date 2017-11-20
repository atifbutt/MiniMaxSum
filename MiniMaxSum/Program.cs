using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            long[] inputArray = Array.ConvertAll(input, long.Parse);

            long[] MinMax = ComputeMinMax(inputArray);
            Console.WriteLine($"{MinMax.Min()} {MinMax.Max()}");
            Console.ReadKey();
        }

        private static long[] ComputeMinMax(long[] inputArray)
        {
            long[] sum = new long[inputArray.Length];
           
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (j != i)
                    {
                        sum[i] += inputArray[j];
                    }
                }
            }
            return sum;
        }
    }
}
