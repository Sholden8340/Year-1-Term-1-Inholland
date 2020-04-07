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

            int[] userNumber = new int[20];
            double average = 0;
            for (int i=0; i < userNumber.Length; i++)
            {
                Console.Write("Enter number {0}:", i+1);
                userNumber[i] = int.Parse(Console.ReadLine());
                average += userNumber[i];
            }
            average /= userNumber.Length;
            Console.WriteLine("\nAverage is {0}\n", average);

            for (int i = 0; i < userNumber.Length; i++)
            {
                double difference;
                if (userNumber[i] < average)
                {
                    difference = (double)average - userNumber[i];
                }
                else
                {
                    difference = (double)userNumber[i] - average;
                }

                Console.WriteLine("Differece between average({0}) and {1}: {2}", average, userNumber[i], difference);
            }


            Console.ReadKey();
            
        }
    }
}
