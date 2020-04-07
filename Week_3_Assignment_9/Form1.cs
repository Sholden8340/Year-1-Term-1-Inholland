using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            const int OVER_40_DISCOUNT = 25;
            const double FOOTBALL_FEE = 175;
            const double HANDBALL_FEE = 225;
            const double TEN_YEAR_DISCOUNT = 20;

            int age = int.Parse(textBoxAge.Text);
            int membershipDuration = int.Parse(textBoxDuration.Text);

            double fee = 0;

            if (radioButtonFootball.Checked)
            {
                fee = FOOTBALL_FEE;
            }
            else if(radioButtonHandball.Checked)
            {
                fee = HANDBALL_FEE;
            }

            if (age >= 40)
            {
                fee -= OVER_40_DISCOUNT;
            }

            if (membershipDuration > 10)
            {
                fee -= TEN_YEAR_DISCOUNT;
            }

            labelFee.Text = "€" + fee.ToString("F2");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
