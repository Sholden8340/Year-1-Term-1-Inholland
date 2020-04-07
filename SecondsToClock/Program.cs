using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsToClock
{
    class Program
    {
        static void Main(string[] args)
        {

            //constants for dividing seconds into hours and minutes
            const int SECONDS_IN_HOUR = 3600;
            const int SECONDS_IN_MINUTE = 60;

            //prompt user and parse input as an integer
            Console.Write("Enter the amount of seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            
            //Calculate amount of full hours and decrement from total seconds
            int hours = seconds / SECONDS_IN_HOUR;
            seconds -= (SECONDS_IN_HOUR * hours); //short way for writing seconds = seconds -(SECONDS_IN_HOUR * hours)

            //Calculate amount of full minutes and decrement from total seconds
            int minutes = seconds / SECONDS_IN_MINUTE;
            seconds -= (SECONDS_IN_MINUTE * minutes);

            //Print and format to look like digital clock
            Console.WriteLine("{0:00}:{1:00}:{2:00} \n", hours, minutes, seconds); // you can use {0}{1}{2} etc. to substitute a variable
            Console.ReadKey(); 


        }
    }
}
