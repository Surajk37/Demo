using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class LeapYr
    {
        public static void Check_LeapYr()
        {
            int year;
            Console.WriteLine("Check Wheather Year is Leap or Not");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter Four Digit Year number");
            year = Convert.ToInt32(Console.ReadLine());

            if (year >= 1000 && year <= 9999)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("{0} Is a leap year : ", year);
                }
                else
                {
                    Console.WriteLine("Is not a leap Year : ", year);
                }
            }
            else
            {
                Console.WriteLine("Enter a valid year");
            }

        }
    }
}
