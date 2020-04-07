using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //promt user for numbers and parse as double
            Console.Write("Enter the first number:");

            //Read the input from the user and try to turn it into a decimal number
            double num1 = Double.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number:");
            double num2 = Double.Parse(Console.ReadLine());

            Console.Write("Enter the third number:");
            double num3 = Double.Parse(Console.ReadLine());

            //calculate the average
            double average = (num1 + num2 + num3) / 3;
            
            //print result
            Console.WriteLine("The average is :" + average);

            //wait for a key to be pressed to exit
            Console.ReadKey();
        }
    }
}
