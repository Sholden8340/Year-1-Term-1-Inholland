using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Enter two numbers. Determine and show whether one number is a multiple of the other number.
            Console.WriteLine("Enter the first number");
            double number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = Double.Parse(Console.ReadLine());

            if ((number1 % number2) == 0)
            {
                Console.WriteLine("{0} is a multiple of {1}", number1 , number2);
            }
            else if ((number2 % number1) == 0)
            {
                Console.WriteLine("{0} is a multiple of {1}", number2, number1);
            }
            else
            {
                Console.WriteLine("Neither are multiples of each other");
            }

            Console.ReadKey();
        }
    }
}
