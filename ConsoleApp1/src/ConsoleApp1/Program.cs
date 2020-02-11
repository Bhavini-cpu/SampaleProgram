using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            long[] arrElement = arr.Select(a => Convert.ToInt64(a)).ToArray();
            miniMaxSum(arrElement);

        }

        private void miniMaxSum(long[] arrElement)
        {
            long minVal = arrElement.Min();
            long maxVal = arrElement.Max();
            long minSum = 0, maxSum = 0;

            if (minVal == maxVal)
            {
                minSum = maxSum = arrElement.Sum() - arrElement[0];
            }
            else
            {
                for (int i = 0; i < arrElement.Length; i++)
                {
                    if (arrElement[i] != maxVal)
                        minSum += arrElement[i];
                    if (arrElement[i] != minVal)
                        maxSum += arrElement[i];
                }
            }
            
            Console.WriteLine($"{minSum} {maxSum}");
            Console.Read();
        }
    }
}
