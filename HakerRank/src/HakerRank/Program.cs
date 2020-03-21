using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakerRank
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Enter program number which you want to run = ");
         int programNumber =  Convert.ToInt32(Console.ReadLine());
       switch (programNumber)
            {
                case 1:
                    var simpleArraySum = new SimpleArraySum();
                    simpleArraySum.Run();
                    break;
                case 2:
                    var CompareTheTriplets = new CompareTheTriplets_2();
                    CompareTheTriplets.Run();
                        break;
                case 3:
                    var VeryBigSum = new VeryBigSum_3();
                    VeryBigSum.Run();
                    break;
                case 4:
                    var daingalDiffrence = new DiagonalDifference_4();
                    daingalDiffrence.Run();
                    break;
                case 5:
                    var plusMinus = new PlusMinus_5();
                    plusMinus.Run();
                    break;
                case 6:
                    var minMaxSum = new Mini_Max_Sum_6();
                    minMaxSum.Run();
                    break;
                case 7:
                    var birthdayCakeCandles = new BirthdayCakeCandles_7();
                    birthdayCakeCandles.Run();
                    break;
                case 8:
                    var timeConversion = new TimeConversion_7();
                    timeConversion.Run();
                    break;
            }
        }
    }
}
