using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter weight (KG)");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height (CM)");
            int heightInCentimeters = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter sex (Male / Female)");
            string sex = Console.ReadLine().ToLower().Trim();

            double height = (double)heightInCentimeters / 100;
            double BMI = weight / (height * height);

            Console.WriteLine("BMI is: {0:#.##}", BMI);

            if (sex == "male")
            {
                Console.WriteLine("Healthy weight is between {0:#.##} and {1:#.##}", (20 * height * height), (25 * height * height) );
            }
            else if (sex == "female")
            {
                Console.WriteLine("Healthy weight is between {0:#.##} and {1:#.##}", (19 * height * height), (24 * height * height));
            }

            Console.ReadKey();
        }
    }
}
