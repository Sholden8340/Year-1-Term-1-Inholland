using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxNumber.Text);
            int check = n * (n + 1) / 2;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            labelSum.Text = sum.ToString();
            labelCheck.Text = check.ToString();
        }
    }
}
