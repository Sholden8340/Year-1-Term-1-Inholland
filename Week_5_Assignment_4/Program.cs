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
            int[] userNumber = new int[20];
            int i = 0;

            for(; i < userNumber.Length; i++)
            {
                Console.Write("Enter a number (0 to exit)");
                userNumber[i] = int.Parse(Console.ReadLine());

                if (userNumber[i] == 0) { break; }
            }

            Console.Write("Enter search number: ");
            int searchNumber = int.Parse(Console.ReadLine());
            int searchCount = 0;

            for(int j = 0; j <= i; j++)
            {
                if (userNumber[j] == searchNumber)
                {
                    searchCount++;
                }
            }

            Console.WriteLine("Number {0} appears {1} times", searchNumber, searchCount);
            Console.ReadKey();
        }
    }
}
