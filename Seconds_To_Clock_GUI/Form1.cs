using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seconds_To_Clock_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //constants for dividing seconds into hours and minutes
            const int SECONDS_IN_HOUR = 3600;
            const int SECONDS_IN_MINUTE = 60;

            int seconds = int.Parse(textBox1.Text);

            //Calculate amount of full hours and decrement from total seconds
            int hours = seconds / SECONDS_IN_HOUR;
            seconds -= (SECONDS_IN_HOUR * hours);

            //Calculate amount of full minutes and decrement from total seconds
            int minutes = seconds / SECONDS_IN_MINUTE;
            seconds -= (SECONDS_IN_MINUTE * minutes);

            //Print and format to look like digital clock
            labelTime.Text = String.Format("{0:00}:{1:00}:{2:00} \n", hours, minutes, seconds);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
