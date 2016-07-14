using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DialogClass_IO_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            textBox1.Font = fontDialog1.Font;

            fontDialog1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            textBox1.ForeColor = colorDialog1.Color;

            colorDialog1.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "Rich Text Document | *.rtf";
            saveFileDialog1.Filter = "Text Document | *.txt";
            saveFileDialog1.ShowDialog();

            string fname = saveFileDialog1.FileName;

            /// string fname = "D:/Teja.txt";
            if (fname != "")
            {
                StreamWriter sw = new StreamWriter(fname);
                sw.Write(textBox1.Text);
                sw.Close();
                               
            }
            else
            {
                textBox1.Focus();
            }

            saveFileDialog1.Dispose();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Document | *.txt";
            openFileDialog1.ShowDialog();
            string fname = openFileDialog1.FileName;

            if(fname!=string.Empty)
            {
                StreamReader sr = new StreamReader(fname);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                textBox1.Focus();
            }

            openFileDialog1.Dispose();
        }
    }
}
