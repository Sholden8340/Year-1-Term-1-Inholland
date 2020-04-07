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
            Console.WriteLine("Enter the first number");
            double number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = Double.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Highest Value is {0} \nLowest value is {1}", number1, number2);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Highest Value is {0} \nLowest value is {1}", number2, number1);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }

            Console.ReadKey();

        }
    }
}
