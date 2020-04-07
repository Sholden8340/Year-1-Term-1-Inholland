using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            //const means constant which means it doesn't change. 
            //You use it for stuff that doesn't change and so that code is more readable and easier to update later
            const double VAT_RATE = 0.21;

            int startKM, endKM; //Create 2 int variables
            double pricePerKM, price, vat, total; //Create 4 doubles
            //They are not initialized which means they don't have a definite value yet

            //Read text boxes
            startKM = int.Parse(textBoxStart.Text);
            endKM = int.Parse(textBoxEnd.Text);
            pricePerKM = Double.Parse(textBoxPrice.Text);

            price = (endKM - startKM) * pricePerKM;

            vat = price * VAT_RATE;

            total = price + vat;

            //formatting to 2 decimal places
            labelPrice.Text = price.ToString("F2");
            labelVAT.Text = vat.ToString("F2");
            labelTotal.Text = total.ToString("F2");


        }
    }
}
