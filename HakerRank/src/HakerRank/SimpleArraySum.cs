using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class SimpleArraySum
    {
        // https://www.hackerrank.com/challenges/simple-array-sum/problem

        public void Run()
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] arrElement = arr.Select(a => Convert.ToInt32(a)).ToArray();
            Console.Write(simpleArraySum(arrElement));
            Console.Read();
        }

        private int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        //private int simpleArraySumAlternative(int[] ar)
        //{
        //    return ar.Sum();
        //}

    }
}
