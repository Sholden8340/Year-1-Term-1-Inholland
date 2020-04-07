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
            Console.WriteLine("Enter the first number");
            double number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            double number3 = Double.Parse(Console.ReadLine());

            if (number1 > number3 && number2 > number3)
            {
                Console.WriteLine("The third number is the smallest");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest");
            }

            Console.ReadKey();
        }
    }
}
