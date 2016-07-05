using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograssBarExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                string startupPath = AppDomain.CurrentDomain.BaseDirectory;
                string targetPath = startupPath + "images\\";
                pictureBox1.Load(targetPath + "1 (3).jpg");

                progressBar1.Hide();

                timer1.Stop();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
