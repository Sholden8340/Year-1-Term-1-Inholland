using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A metal turning lathe will be replaced by a new lathe at the end of the year if one or more of the
            following conditions have been met:
                more than 10,000 working hours
                7 years old or more
                 more than 25 failures a year
                Enter the necessary data.You must show whether the turning lathe needs to be replaced.*/

            const int MAX_FAILURES_PER_YEAR = 25; //do i need to divide by year
            const int MAX_YEARS_OLD = 6;
            const int MAX_WORKING_HOURS = 10000;

            int workedHours, workedYears, failuresPerYear;

            Console.Write("Enter Number of working hours: ");
            workedHours = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of years old: ");
            workedYears = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of failures per year: ");
            failuresPerYear = int.Parse(Console.ReadLine());

            if (workedHours > MAX_WORKING_HOURS || failuresPerYear > MAX_FAILURES_PER_YEAR || workedYears > MAX_YEARS_OLD)
            {
                Console.WriteLine("\nMachine needs to be replaced");
            }
            else
            {
                Console.WriteLine("\nMachine does not need to be replced");
            }

            Console.ReadKey();
        }
    }
}
