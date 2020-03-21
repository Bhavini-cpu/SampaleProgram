using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class DiagonalDifference_4
    {
        public void Run()
        {
            // https://www.hackerrank.com/challenges/diagonal-difference/problem
            int n = Convert.ToInt32(Console.ReadLine());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);
        }

        private int diagonalDifference(List<List<int>> arr)
        {
            int result = 0;
            int length = arr.Count;

            int[] arr1 = new int[length];
            int[] arr2 = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr1[i] = arr[i][i];
                arr2[i] = arr[i][(length - i) - 1];
            }
            int sumOfArr1 = arr1.Sum();
            int sumOfArr2 = arr2.Sum();
            if (sumOfArr1 > sumOfArr2)
                result = sumOfArr1 - sumOfArr2;
            else
                result = sumOfArr2 - sumOfArr1;
            return result;
        }
    }
}
