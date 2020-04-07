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

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            int size = int.Parse(textBoxSize.Text);
            labelSquare.Text = "";

            for (int i = 0; i < size; i++)
            {
                for (int j =0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        labelSquare.Text += "X";
                    }
                    else
                    {
                        labelSquare.Text += " ";
                    }
                    
                }
                labelSquare.Text += "\n";
            }
        }
    }
}
