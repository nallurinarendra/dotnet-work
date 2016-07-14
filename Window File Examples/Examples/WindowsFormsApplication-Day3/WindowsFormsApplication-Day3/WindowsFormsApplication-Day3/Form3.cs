using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Day3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // start timer
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value>=progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show(" Your Prograss is Completed...");
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }
    }
}
