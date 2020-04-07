using System;
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
            Console.Write("Enter a number (1 .. 4)");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice) {

                case 1:
                    Console.WriteLine("Clubs");
                    break;
                case 2:
                    Console.WriteLine("Diamonds");
                    break;
                case 3:
                    Console.WriteLine("Hearts");
                    break;
                case 4:
                    Console.WriteLine("Spades");
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;

            }
            Console.ReadKey();
        }
    }
}
