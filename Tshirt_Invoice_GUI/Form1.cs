using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tshirt_Invoice_GUI
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            const double VAT_RATE = 0.21;
            const double TSHIRT_COST = 30;
            const double JEANS_COST = 100;

            int noOfTshirts = int.Parse(textBoxTshirt.Text);
            int noOfJeans = int.Parse(textBoxJeans.Text);

            double price = (noOfJeans * JEANS_COST) + (noOfTshirts * TSHIRT_COST);
            double vat = price * VAT_RATE;
            double total = vat + price;

            labelDate.Text = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy"); //had to google this. Same as F2 kinda but 
            labelPrice.Text = "€" + price.ToString("F2");
            labelVat.Text = "€" + vat.ToString("F2");
            labelTotal.Text = "€" + total.ToString("F2");


        }

        private void LabelDate_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
