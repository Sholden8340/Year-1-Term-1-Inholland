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
            int total = 0;
            int count = 1;

            do
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else if (count % 5 == 0)
                {
                    total += number;
                }

                count++;

            } while (true);

            Console.WriteLine("Sum of every 5th number = {0}", total);
            Console.ReadKey();
        }
    }
}
