using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class Mini_Max_Sum_6
    {
        public void Run()
        {
            //https://www.hackerrank.com/challenges/mini-max-sum/problem
            string[] arr = Console.ReadLine().Split(' ');
            int[] arrElement = arr.Select(a => Convert.ToInt32(a)).ToArray();
            miniMaxSum(arrElement);
        }

        private void miniMaxSum(int[] arrElement)
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
