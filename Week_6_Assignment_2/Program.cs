using System;
using System.Collections;
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
            ArrayList numbers = new ArrayList();
            do
            {
                
                Console.Write("Enter a number (0 to exit): ");
                int number = int.Parse(Console.ReadLine());

                if(number > 0)
                {
                    numbers.Add(number);
                }
                else if (number == 0)
                {
                    break;
                }
            } while (true);

            foreach(int i in numbers)
            {
                Console.Write("{0} ", i);
                if (IsPrime(i))
                {
                    Console.Write("is a Prime number\n");
                }
                else
                {
                    Console.Write("is not a Prime number\n");
                }
            }

            Console.ReadKey();
        }

        private static bool IsPrime(int input)
        {
            bool prime = true;
            for(int i = 2; i <= input/2; i++)
            {
                if(input % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
    }
}
