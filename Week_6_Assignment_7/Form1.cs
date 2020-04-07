using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            //Implement a method for each conversion. These 3 methods must be called with an argument, i.e.the
            //temperature that should be converted.Each method returns the converted temperature value.Use the
            //following method names: Celsius2Kelvin(c), Celsius2Fahrenheit(c) and Fahrenheit2Celsius(f).
            //Conversion formulas(C: Celsius, K: Kelvin and F: Fahrenheit):
            // c °C > (c + 273) K
            // c °C > (c × 9 / 5 + 32) °F
            // f °F > ((f - 32) × 5 / 9) °C

            double degrees = double.Parse(textBoxDegrees.Text);
            double result = 0;

            if (radioButtonCelsiusKelvin.Checked)
            {
                result = Celsius2Kelvin(degrees);
            }
            else if (radioButtonCelsiusFahrenheight.Checked)
            {
                result = Celsius2Fahrenheit(degrees);
            }
            else if (radioButtonFahrenheightCelsius.Checked)
            {
                result = Fahrenheit2Celsius(degrees);
            }

            labelResult.Text = result.ToString("F2");
        }

        private double Celsius2Kelvin(double degrees)
        {
            return degrees+273;
        }

        private double Celsius2Fahrenheit(double degrees)
        {
            return degrees * 9 / 5 + 32;
        }

        private double Fahrenheit2Celsius(double degrees)
        {
            return (degrees - 32) * 5/9;
        }
    }
}
