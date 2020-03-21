using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class BirthdayCakeCandles_7
    {
        public void Run()
        {
            //https://www.hackerrank.com/challenges/birthday-cake-candles/problem

            int arCount = Convert.ToInt32(Console.ReadLine());

            string[] arr = Console.ReadLine().Split(' ');
            int[] arrElement = arr.Select(a => Convert.ToInt32(a)).ToArray();
            int result = birthdayCakeCandles(arrElement);

            Console.WriteLine(result);
        }
        static int birthdayCakeCandles(int[] ar)
        {
            int maxVal = ar.Max();
            return ar.Where(a => a == maxVal).Count();

        }
    }
}
