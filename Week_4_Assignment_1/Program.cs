using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int total = 0;
            do
            { 
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    total += number;
                    count++;
                }
                else if(number == 0)
                {
                    break;
                }

            } while (true);

            Console.WriteLine("The Average of all the positive numbers = {0:0.00}", total / count);
            Console.ReadKey();
        }
    }
}
