using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter three numbers. Show the sum, average, product, highest and lowest of the numbers.

            Console.WriteLine("Enter the first number");
            double number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            double number3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("The sum is: {0}", number1 + number2 + number3);
            Console.WriteLine("The average is: {0}", (number1 + number2 + number3) / 3);
            Console.WriteLine("The product is: {0}", number1 * number2 * number3);

            double smallestNumber, biggestNumber;

            if (number1 > number2)
            {
                biggestNumber = number1;
                smallestNumber = number2;
            }
            else
            {
                biggestNumber = number2;
                smallestNumber = number1;
            }

            if (number3 > biggestNumber)
            {
                 biggestNumber = number3;
            }
            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }

            Console.WriteLine("The biggest is: {0}", biggestNumber);
            Console.WriteLine("The smallest is: {0}", smallestNumber);

            Console.ReadKey();

        }
    }
}
