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
            int number1, number2, result;

            number1 = 1;
            number2 = 1;

            Console.Write("{0}, {1}", number1, number2);
            for(int i = 2; i < 20; i++)
            {
                result = number1 + number2;
                number1 = number2;
                number2 = result;
                Console.Write(" {0},", result);
            }
            Console.ReadKey();
        }
    }
}
