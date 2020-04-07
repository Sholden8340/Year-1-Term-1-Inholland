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

        private int[] numbers = new int[20];
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 500);
            }
        }

        private void ButtonCompare_Click(object sender, EventArgs e)
        {

            labelBefore.Text = "";
            labelAfter.Text = "";
            int compare = int.Parse(textBoxCompare.Text);

            for (int i = 0; i < numbers.Length; i++)
            {
                
                labelBefore.Text += "\n" + numbers[i];
                if (numbers[i] > compare)
                {
                    labelAfter.Text += "\n" + (numbers[i] + 10);
                }
                else
                {
                    labelAfter.Text += "\n" + (numbers[i] - 5);
                }
            }


            buttonCompare.Enabled = false;
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
