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
            int[] number = new int[20];
            Random rng = new Random();
            int min = 0;
            int count = 0;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rng.Next(0, 150);
                if (number[i] < min || i == 0)
                {
                    min = number[i];
                    count = 1;
                }
                else if (number[i] == min)
                {
                    count++;
                }
                Console.WriteLine("Number {0} is: {1}", i + 1, number[i]);
            }

            Console.WriteLine("\n\nSmallest number is: {0}", min);
            Console.WriteLine("Number of occurences is: {0}", count);
            Console.ReadKey();
        }
    }
}
