using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                int number = 0;
                Console.Write("\nEnter a number: ");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if (number <= 1)
                {
                    Console.WriteLine("Enter a number greater than 1");
                }
                int factor = number;
                int count = 2;
                while (number >= 1 && count <=  number)
                {
                    //Console.WriteLine("count {0} number: {1}", count, number );
                    
                    if ((IsPrime(count) && factor % count == 0) || factor == count)
                    {
                        Console.Write("{0} ",count);
                        factor = factor / count;
                    }
                    else
                    {
                        count++;
                    }

                }

            } while (true);

            Console.WriteLine("End of Program");
            Console.ReadKey();
        }

        private static bool IsPrime(int input)
        {
            bool prime = true;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0 && i != 2)
                {
                    prime = false;
                }
            }
            //Console.WriteLine("Prime: {0} Number: {1}", prime, input);
            return prime;
        }
    }
}
