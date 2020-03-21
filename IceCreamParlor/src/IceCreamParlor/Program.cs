using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlor
{
    public class Program
    {
        public void Main(string[] args)
        {
            int noOfTreat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfTreat; i++)
            {
                int money = Convert.ToInt32(Console.ReadLine());

                int numberOfFlaviour = Convert.ToInt32(Console.ReadLine());

                var arr = Console.ReadLine().Split(' ');
                int[] flaviorWiseCost = arr.Select(a => Convert.ToInt32(arr)).ToArray();
                ;
                int[] result = funcIcecreamParlor(money, flaviorWiseCost);
                Console.WriteLine();
            }


        }

        private int[] funcIcecreamParlor(int money, int[] flaviorWiseCost)
        {
            int sum = flaviorWiseCost[0];
            for (int i = 0; i < flaviorWiseCost.Length; i++)
            {
                if (sum + flaviorWiseCost[i + 1] == money)
                {
                    return new[] { 1, i + 1 };
                }
            }
            return new[] { 1, 1 };
        }
    }
}
