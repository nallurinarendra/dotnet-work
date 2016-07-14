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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                // check couse name in listbox 

               
                if (comboBox1.Items.Contains(textBox1.Text) == true)
                {
                    MessageBox.Show(" This course Already added....");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show(" Please Enter Your Course Name....");
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only take the Letters

            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13)
            {
                e.Handled = false;

                if (e.KeyChar == 13)
                {
                    if (textBox1.Text != "")
                    {
                        if (comboBox1.Items.Contains(textBox1.Text) == true)
                        {
                            MessageBox.Show(" This course Already added....");
                        }
                        else
                        {
                            comboBox1.Items.Add(textBox1.Text);
                            textBox1.Clear();
                            textBox1.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Please Enter Your course Name...");
                        textBox1.Focus();
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                MessageBox.Show("Your Item Remove Sucessfully...");
            }
            else
            {
                MessageBox.Show(" Please Select Your Deleted Course Name....");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.Items.Contains(comboBox1.SelectedItem.ToString()) == false)
            {
                comboBox2.Items.Add(comboBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show(" This course already added.....");
            }
        }
    }
}
