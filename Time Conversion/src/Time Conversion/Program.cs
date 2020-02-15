using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Time_Conversion
{
    public class Program
    {
        public void Main(string[] args)
        {
            string time = Console.ReadLine();

            string result = timeConversion(time);

            Console.WriteLine(result);

        }

        private string timeConversion(string time)
        {
            DateTime dt = DateTime.Parse(time);
            return dt.ToString("HH:mm");
        }
    }
}
