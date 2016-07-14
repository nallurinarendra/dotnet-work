using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("D:\\01-08-2015\\Desktopimages\\1 (1).jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // folder your can maintain Myimages in bin/debug floder
            string loacation = Application.StartupPath + "\\MyImages\\1 (2).jpg";
            pictureBox1.Load(loacation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string targetPath = startupPath + "MyImages\\";
            pictureBox1.Load(targetPath + "1 (3).jpg");
        }

       
    }
}
