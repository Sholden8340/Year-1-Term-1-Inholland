﻿using System;
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

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            const double INTEREST_RATE = 0.05;

            double total = double.Parse(textBoxStart.Text);

            for(int i = 0; i <5; i++)
            {
                total += total * INTEREST_RATE;
            }
            labelResult.Text = "€" + total.ToString("F2");
        }
    }
}
