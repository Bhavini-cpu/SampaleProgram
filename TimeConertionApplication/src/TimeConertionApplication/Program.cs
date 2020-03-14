using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeConertionApplication
{
    public class Program
    {
        // https://www.hackerrank.com/challenges/time-conversion/problem
        public void Main(string[] args)
        {
            string time = Console.ReadLine();

            string result = timeConversion(time);

            Console.WriteLine(result);

        }

        private string timeConversion(string time)
        {
            DateTime dt = DateTime.Parse(time);
            return dt.ToString("HH:mm:ss");
        }
    }
}
