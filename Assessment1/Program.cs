using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_CREDITS = 60;
            const double PASS_PERCENTAGE = .75;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of EC Excemption credits: ");
            int exemptionCredits = int.Parse(Console.ReadLine());

            Console.Write("Enter total number of EC credits for the year: ");
            int credits = int.Parse(Console.ReadLine());

            double minimum = (double)(MAX_CREDITS - exemptionCredits) * PASS_PERCENTAGE;

            //credits += exemptionCredits;
            Console.WriteLine("Minium credits to go to 2nd year: {0}\n", minimum + exemptionCredits);

            //Console.WriteLine("{0} {1}", credits /(MAX_CREDITS - exemptionCredits), PASS_PERCENTAGE);
            

            if (credits >= minimum + exemptionCredits) 
            {
                Console.WriteLine("{0} you have enough credits to go to 2nd year", name);
            }
            else
            {
                Console.WriteLine("{0} you do not have enough credits to go to 2nd year", name);
            }
            Console.ReadKey();

        }
    }
}
