using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            double num1, num2;
            getNumbers(out num1, out num2);
            double result = AddNumbers(num1, num2);

            labelResult.Text = result.ToString();
        }

        private void getNumbers(out double number1, out double number2)
        {
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);
        }

        private  double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        private double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        private double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        private double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            double num1, num2;
            getNumbers(out num1, out num2);
            double result = SubtractNumbers(num1, num2);

            labelResult.Text = result.ToString();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            double num1, num2;
            getNumbers(out num1, out num2);
            double result = MultiplyNumbers(num1, num2);

            labelResult.Text = result.ToString();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            double num1, num2;
            getNumbers(out num1, out num2);
            double result = DivideNumbers(num1, num2);

            labelResult.Text = result.ToString();
        }
    }
}
