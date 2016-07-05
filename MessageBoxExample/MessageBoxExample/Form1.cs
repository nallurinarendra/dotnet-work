using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to Message Box ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to Message Box ", " MyBox ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to Message Box ", " MyBox ",MessageBoxButtons.AbortRetryIgnore);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to Message Box ", " MyBox ", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
           DialogResult result=MessageBox.Show(" Are u Understand Dotnet ", "Mahesh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result.ToString ()=="Yes")
            {
                MessageBox.Show(" Yes Sir ");
            }
            else
            {
                MessageBox.Show(" No Sir");
            }
        }
    }
}
