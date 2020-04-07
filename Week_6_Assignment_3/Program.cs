using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            do
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());

                if(year == 0) { break; }

                if (IsLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", year);
                }

            } while (true);
            Console.WriteLine("0: Exit");
            Console.ReadKey();
        }

        private static bool IsLeapYear(int year)
        {

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
