using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Average_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            //Same as console version. Read the text from the text box and try to store it as a double, add them and divide by 3
            double average = (Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text) + Double.Parse(textBox3.Text)) / 3;

            //F is for fixed point decimal so it means 3 decimal places 
            //.ToString takes the number and changes it into text
            labelAverage.Text = average.ToString("F3");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
