using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class PlusMinus_5
    {
        public void Run()
        {
            // https://www.hackerrank.com/challenges/plus-minus/problem
            string[] arr = Console.ReadLine().Split(' ');
            int[] arrElement = arr.Select(a => Convert.ToInt32(a)).ToArray();
            plusMinus(arrElement);
        }

        private void plusMinus(int[] arr)
        {
            float countOfPositiveNumber = 0;
            float countOfNegativeNumber = 0;
            float countOfZero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    countOfPositiveNumber++;
                }
                else if (arr[i] < 0)
                {
                    countOfNegativeNumber++;
                }
                else
                {
                    countOfZero++;
                }
            }

            List<float> result = new List<float>();
            result.Add(countOfPositiveNumber / arr.Length);
            result.Add(countOfNegativeNumber / arr.Length);
            result.Add(countOfZero / arr.Length);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
           
        }
    }
}
