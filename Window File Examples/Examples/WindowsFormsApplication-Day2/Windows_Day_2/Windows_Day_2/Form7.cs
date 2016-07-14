using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Day_2
{
    public partial class Form7 : Form
    {

        // variable
        double billamount;

        public Form7()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                billamount = billamount + 25000;
            }
            else
            {
                billamount = billamount - 25000;
            }

            textBox1.Text = billamount.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                billamount = billamount + 35000;
            }
            else
            {
                billamount = billamount - 35000;
            }

            textBox1.Text = billamount.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                billamount = billamount + 2500;
            }
            else
            {
                billamount = billamount - 2500;
            }

            textBox1.Text = billamount.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                billamount = billamount + 250;
            }
            else
            {
                billamount = billamount - 250;
            }

            textBox1.Text = billamount.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                billamount = billamount + 350;
            }
            else
            {
                billamount = billamount - 350;
            }

            textBox1.Text = billamount.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                billamount = billamount + 2000;
            }
            else
            {
                billamount = billamount - 2000;
            }

            textBox1.Text = billamount.ToString();
        }
    }
}
