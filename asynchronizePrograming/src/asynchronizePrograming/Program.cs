using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asynchronizePrograming
{
    public class Program
    {
        static void Main(string[] args)
        {
        Task t1 = Method1("msg 1");
        Task t2 = Method1("msg 2");

            Method2();
            Console.Read();
        }

        public static async Task Method1(string msg)
        {
            Console.WriteLine(" ==== " + msg);
            Console.WriteLine(" == " + msg);
            Console.WriteLine(" = " + msg);
            Console.WriteLine(" === " + msg);
            Console.WriteLine(" == " + msg);

            int count = 1;
            await Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                { 
                    if(i == 0)
                    {
                        count = 20;
                    }
                    Console.WriteLine(" Method 1 "+ msg);
                }
            });
        }


        public static void Method2()
        {
            //for (int i = 0; i < 25; i++)
            //{
            //    Console.WriteLine(" Method 2");
            //}
        }
    }
}
