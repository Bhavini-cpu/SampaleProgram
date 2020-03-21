using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9__Feb___2020
{
    public class Program
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

        }

        private int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count; i += m)
            {
                if (makePair(i, s, m) == d) {
                    count++;
                } ;
            }
            return count;
        }

        private int makePair(int i , List<int> s,int m)
        {
            int sum = 0;
            for (int a = 0; a < s.Count; a++)
            {
                 if (a >= i && a< i+(m-1))
                {
                    sum += s[a];
                }
            }
            return sum;
        }
    }
}
