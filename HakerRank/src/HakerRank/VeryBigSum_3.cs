using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class VeryBigSum_3
    {
        public void Run()
        {
            // https://www.hackerrank.com/challenges/a-very-big-sum/problem
            string[] arr = Console.ReadLine().Split(' ');
            long[] arrElement = arr.Select(a => Convert.ToInt64(a)).ToArray();

            long result = aVeryBigSum(arrElement);

            Console.WriteLine(result);

        }

        private long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }
    }
}
