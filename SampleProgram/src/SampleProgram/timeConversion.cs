using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProgram
{
    public class timeConversion
    {
     
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string result = funcTimeConversion(userInput);
            Console.WriteLine(result);
            Console.Read();
        }

        private static string funcTimeConversion(string userInput)
        {
           return string.Format("HH:mm",userInput);
        }
    }
}
