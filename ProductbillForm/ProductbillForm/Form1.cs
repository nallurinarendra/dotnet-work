using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductbillForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Billamount()
        {
            if (textBox_Rate.Text != " " && textBox_Quantity.Text != " ")
            {
                double productRate = double.Parse(textBox_Rate.Text);
                int qty = int.Parse(textBox_Quantity.Text);

                double bill_amount = productRate * qty;

                textBox_BillAmount.Text = bill_amount.ToString();
            }
            else
            {
                MessageBox.Show("please enter the Quantity and rate");
            }
        }
        private void textBox_ProdcutNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_ProdcutNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
                

            }
            else
            {
                e.Handled = true;
        
            }
            if (e.KeyChar == 13)
            {
                Billamount();

            }
        }

        private void button_Next_MouseClick(object sender, MouseEventArgs e)
        {

            textBox_BillAmount.Clear();
            textBox_ProdcutNo.Clear();
            textBox_ProductName.Clear();
            textBox_Quantity.Clear();
            textBox_Rate.Clear();
            textBox_ProdcutNo.Focus();


        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

