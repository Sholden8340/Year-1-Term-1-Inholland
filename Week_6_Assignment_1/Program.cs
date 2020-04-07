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
            Console.Write("Enter a Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Price: {0:0.00} VAT: {1:0.00} Total: {2:0.00}", price, Calculate_VAT(price), price + Calculate_VAT(price));
            Console.ReadKey();
        }

        static double Calculate_VAT(double price)
        {
            const double VAT_RATE = 0.21;

            return price * VAT_RATE;
        }
    }
}
