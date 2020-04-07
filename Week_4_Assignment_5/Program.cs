using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
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

                if (year == 0)
                {
                    break;
                }
                if(year %4 == 0)
                {
                    if (year % 100 == 0 && year % 400 != 0)
                    {
                        Console.WriteLine("{0} is not leap year", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is a leap year", year);
                    }
                    
                }
            } while (true);

            Console.ReadKey();
        }
    }
}
