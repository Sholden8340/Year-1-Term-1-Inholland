using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            const double FIRST_CLASS_PRICE = 87.46;
            const double SECOND_CLASS_PRICE = 53;
            const double RAILRUNNER_PRICE = 2.50;

            double total = 0;
            int noOfTickets = int.Parse(textBoxTickets.Text);
            int noOfRailrunner = int.Parse(textBoxRailrunner.Text);

            if (radioButtonFirst.Checked)
            {
                total += FIRST_CLASS_PRICE * noOfTickets;
            }
            else if(radioButtonSecond.Checked)
            {
                total += SECOND_CLASS_PRICE * noOfTickets;
            }

            total += RAILRUNNER_PRICE * noOfRailrunner;

            textBoxPrice.Text = total.ToString("F2");
        }
    }
}
