using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rng = new Random();
            const int AMOUNT_OF_NUMBERS = 20;
            const int MAX_RANDOM = 99;
            const int MIN_RANDOM = 0;

            int[] numbers = new int[AMOUNT_OF_NUMBERS];

            int min = 100;
            int max = 1;

            for (int i = 0; i < AMOUNT_OF_NUMBERS; i ++)
            {
                numbers[i] = rng.Next(MIN_RANDOM, MAX_RANDOM+1);

                if (numbers[i] < min) 
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Minimum Value: {0}", min);
            Console.WriteLine("Maximum Value: {0}", max);

            foreach (int i in numbers)
            {
                if (i > min + 20 && i < max - 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0} ", i);
                }
                else if (i > min + 10 && i < max - 10) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0} ", i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
