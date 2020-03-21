using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class TimeConversion_7
    {
        static string timeConversion(string time)
        {
            //https://www.hackerrank.com/challenges/time-conversion/problem
            DateTime dt = DateTime.Parse(time);
            return dt.ToString("HH:mm:ss");
        }

        public void Run()
        {

            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

        }
    }
}
