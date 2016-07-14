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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                // check couse name in listbox 

                if (listBox1.Items.Contains(textBox1.Text) == true)
                {
                    MessageBox.Show(" This course Already added....");
                }
                else
                {
                    listBox1.Items.Add(textBox1.Text);
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

            if(char.IsLetter(e.KeyChar) || e.KeyChar==8 || e.KeyChar==13)
            {
                e.Handled = false;

                if(e.KeyChar==13)
                {
                    if (textBox1.Text != "")
                    {
                        if (listBox1.Items.Contains(textBox1.Text) == true)
                        {
                            MessageBox.Show(" This course Already added....");
                        }
                        else
                        {
                            listBox1.Items.Add(textBox1.Text);
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
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Your Item Remove Sucessfully...");
            }
            else
            {
                MessageBox.Show(" Please Select Your Deleted Course Name....");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Contains(listBox1.SelectedItem.ToString()) == false)
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show(" This course already added.....");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
