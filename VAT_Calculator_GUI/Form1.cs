using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAT_Calculator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //vat rate as a constant
            const double VAT_RATE = 0.21;

            double price = Double.Parse(textBoxPrice.Text);
            double vat = price * VAT_RATE;
            double total = price + vat;

            priceOutput.Text = price.ToString("F2");
            vatOutput.Text = vat.ToString("F2");
            totalOutput.Text = total.ToString("F2");

        }
    }
}
