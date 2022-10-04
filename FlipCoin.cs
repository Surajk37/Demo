using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static  class FlipCoin
    {
        public static void CalculatePercenteage()
        {
            Console.WriteLine("Please enter the value for number of Flips");
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int FlipCoin = Convert.ToInt32(Console.ReadLine());

            if (FlipCoin > 0)
            {
                for (int i = 0; i < FlipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The random number generated : " + number);

                    if (number == 0)
                    {
                        TailCount++;
                    }
                    else
                    {
                        HeadCount++;
                    }
                    Console.WriteLine("{0} The count of head is : ", HeadCount);
                    Console.WriteLine("{0} The count of tail is : ", TailCount);

                    HeadPercentage = HeadCount * 100 / FlipCoin;
                    TailPercentage = TailCount * 100 / FlipCoin;

                    Console.WriteLine("Percentage of Head is : " + HeadPercentage);
                    Console.WriteLine("{0} Peercentage of Tail is : ", TailCount);
                }
            }
            else
            {
                Console.WriteLine("Please enter positive Number or Greater than zero");
            }
        }
    }
}
