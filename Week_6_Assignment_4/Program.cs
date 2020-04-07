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

            Console.Write("Enter text: ");
            string userText = Console.ReadLine();

            int noOfCommas= 0, noOfSemiColons = 0, noOfFullStops = 0;

            SearchText(userText, out noOfCommas, out noOfSemiColons, out noOfFullStops);

            Console.WriteLine("There are {0} full stops", noOfFullStops);
            Console.WriteLine("There are {0} commas", noOfCommas);
            Console.WriteLine("There are {0} semicolons", noOfSemiColons);
            Console.ReadKey();
        }

        static void SearchText(string text, out int noOfCommas, out int noOfSemiColons, out int noOfFullStops)
        {
            noOfCommas = 0;
            noOfFullStops = 0;
            noOfSemiColons = 0;

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('.'))
                {
                    noOfFullStops++;
                }
                else if (text[i].Equals(','))
                {
                    noOfCommas++;
                }
                else if (text[i].Equals(';'))
                {
                    noOfSemiColons++;
                }
            }
        }
    }
}
