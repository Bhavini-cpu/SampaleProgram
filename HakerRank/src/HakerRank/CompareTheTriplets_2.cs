using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class CompareTheTriplets_2
    {
        public void Run()
        {
            //https://www.hackerrank.com/challenges/compare-the-triplets/problem
            List<int> firstTriplet = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> secondTriplet = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(firstTriplet, secondTriplet);
            Console.WriteLine(String.Join(" ", result));
        }

        private List<int> compareTriplets(List<int> firstTriplet, List<int> secondTriplet)
        {
            List<int> result = new List<int>(2) { 0, 0 };
            foreach (var temp in firstTriplet)
            {
                foreach (var temp2 in secondTriplet)
                {
                    if (temp > temp2)
                        result[0]++;
                    else if (temp < temp2)
                        result[1]++;
                    secondTriplet.Remove(temp2);
                    break;
                }
            }
            return result;
        }
    }
}
