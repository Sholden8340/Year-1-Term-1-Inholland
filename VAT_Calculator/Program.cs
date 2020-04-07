using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //vat rate as a constant
            const double VAT_RATE = 0.21;

            Console.Write("Enter a price: ");

            double price = Double.Parse(Console.ReadLine());
            double vat = price * VAT_RATE;
            double total = price + vat;

            Console.WriteLine("Price: \t{0:00} \nVAT: \t{1:00} \nTotal: \t{2:00} \n", price , vat, total); // {0} used to swap in price. the :00 part formats it to 2 decimals
            Console.ReadKey();

        }
    }
}
