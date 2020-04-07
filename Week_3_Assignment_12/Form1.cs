using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            Assignment 12 (Windows Application)
//             Calculate the price of a cinema ticket as follows:
//                  the basic price is €12 (make it a constant value).
//                  enter the age.
//                  under 5 years: free
//                  from 5 to 12 years: half price
//                  from 13 to 54 years: full price
//                  from 55 years: free
//                  Show the price of a cinema ticket.
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            const double BASE_PRICE = 12;
            const double UNDER_5_MULTIPLIER = 0;
            const double UNDER_13_MULTIPLIER = 0.5;
            const double OVER_55MULTIPLIER = 0;

            double price = BASE_PRICE;
            int age = int.Parse(textBoxAge.Text);

            if (age >= 55)
            {
                price *= OVER_55MULTIPLIER;
            }
            else if(age < 5)
            {
                price *= UNDER_5_MULTIPLIER;
            }
            else if (age < 13)
            {
                price *= UNDER_13_MULTIPLIER;
            }

            labelPrice.Text = "€" + price.ToString("F2");
        }
    }
}
