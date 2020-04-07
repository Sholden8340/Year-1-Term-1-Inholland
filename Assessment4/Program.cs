using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            const int AMOUNT_OF_NUMBERS= 10;

            int[] number1 = new int[AMOUNT_OF_NUMBERS];
            int[] number2 = new int[AMOUNT_OF_NUMBERS];
            int remainder;

            for (int i =0; i < AMOUNT_OF_NUMBERS; i++)
            {
                number1[i] = rng.Next(1, 51);
                number2[i] = rng.Next(1, 6);
               // Console.WriteLine("rng");
            }
            
            for (int i =0; i < AMOUNT_OF_NUMBERS; i++)
            {
                //Console.WriteLine("numbers");
                int product = IntegerDivision(number1[i], number2[i], out remainder);
                Console.WriteLine("{0}. {1} / {2} = {3} ({4})",i+1, number1[i], number2[i], product, remainder);
            }
            Console.WriteLine("Program end");
            Console.ReadKey();
        }

        static int IntegerDivision(int number1, int number2, out int remainder)
        {
            int count = 0;
            int product = number1;
            remainder = 0;

            //works once then loops infinitely
            while (true)
            {
                if( product - number2 > 0)
                {
                    //Console.WriteLine("product: {0}", product);
                    product -= number2;
                    count++;
                }
                else if (number2 > product)
                {
                    //Console.WriteLine("reamain");
                    remainder = product;
                    break;
                }
                else
                {
                    break;
                }

            }
            return count;
        }
    }
}
