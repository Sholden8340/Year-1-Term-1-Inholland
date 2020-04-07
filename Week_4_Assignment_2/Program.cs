using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.Write("Enter a target number: ");
            int target = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number == target)
                {
                    count++;
                }
                else if (number == 0)
                {
                    break;
                }

            } while (true);

            Console.WriteLine("Target count = {0}" +
                "", count);
            Console.ReadKey();
        }
    }
}
