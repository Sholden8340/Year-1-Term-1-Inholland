using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)//Reference
        {
            int number = int.Parse(textBox1.Text);
            SquareByReference(ref number);
            labelResult.Text = number.ToString();
        }

        void SquareByReference(ref int number)
        {
               number *= number;
        }
        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }
        int SquareByValue(int number)
        {
            return number * number;
        }

        private void ButtonSqValue_Click(object sender, EventArgs e)
        {
            labelResult.Text = SquareByValue(int.Parse(textBox1.Text)).ToString();
        }

        private void ButtonRefferenceOut_Click(object sender, EventArgs e)
        {
            int number = 0;
            SquareByReferenceOut(int.Parse(textBox1.Text), out number);
            labelResult.Text = number.ToString();
        }
    }
}
