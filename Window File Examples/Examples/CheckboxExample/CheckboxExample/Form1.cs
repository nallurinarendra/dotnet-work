using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxExample
{
    public partial class Form1 : Form
    {
        double bill_amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                bill_amount = bill_amount + 25000;
            }
            else
            {
                bill_amount = bill_amount - 25000;
            }

            textBox1.Text = bill_amount.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                bill_amount = bill_amount + 35000;
            }
            else
            {
                bill_amount = bill_amount - 35000;
            }

            textBox1.Text = bill_amount.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                bill_amount = bill_amount + 2500;
            }
            else
            {
                bill_amount = bill_amount - 2500;
            }

            textBox1.Text = bill_amount.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                bill_amount = bill_amount + 2500;
            }
            else
            {
                bill_amount = bill_amount - 2500;
            }

            textBox1.Text = bill_amount.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                bill_amount = bill_amount + 5000;
            }
            else
            {
                bill_amount = bill_amount - 5000;
            }

            textBox1.Text = bill_amount.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                bill_amount = bill_amount + 10000;
            }
            else
            {
                bill_amount = bill_amount - 10000;
            }

            textBox1.Text = bill_amount.ToString();
        }
    }
}
