using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEventsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "100";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "50";
        }
    }
}
