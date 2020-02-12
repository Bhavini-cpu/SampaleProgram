using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProgram
{
    public class Program
    {
        public void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] arrElement = arr.Select(a => Convert.ToInt32(a)).ToArray();
            int result = birthdayCakeCandles(arrElement);
            Console.WriteLine(result);
            Console.Read();
        }

        private int birthdayCakeCandles(int[] ar)
        {
            int maxVal = ar.Max();
            return ar.Where(a => a == maxVal).Count();
        }
    }
}
