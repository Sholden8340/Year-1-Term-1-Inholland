using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GRADE_A = 90;
            const int GRADE_B = 80;
            const int GRADE_C = 70;
            const int GRADE_D = 60;

            Console.WriteLine("Enter result");
            double result = Double.Parse(Console.ReadLine());

            if (result >= GRADE_A)
            {
                Console.WriteLine("Grade: A");
            }
            else if (result >= GRADE_B)
            {
                Console.WriteLine("Grade: B");
            }
            else if (result >= GRADE_C)
            {
                Console.WriteLine("Grade: C");
            }
            else if (result >= GRADE_D)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            if (result < 60)
            {
                Console.WriteLine("You have failed");
            }
            else
            {
                Console.WriteLine("You have passed");
            }

            Console.ReadKey();
        }
    }
}
