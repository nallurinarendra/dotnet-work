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

namespace DialogClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
            colorDialog1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            fontDialog1.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open save dislaog
            saveFileDialog1.Filter = "Text Documents|*.txt";
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            if (filename!=string.Empty)
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(textBox1.Text);
                sw.Close();
                MessageBox.Show("File Save Sucessfully");

            }
            else
            {
                MessageBox.Show(" Please enter filename at the time of save");
            }
            saveFileDialog1.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // filter open file dialog
            openFileDialog1.Filter= "Text Documents|*.txt";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            if(filename!=string.Empty)
            {
                // use stream reader
                StreamReader sr = new StreamReader(filename);
                textBox1.Clear();
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                MessageBox.Show(" Please enter filename at the time of save");
            }

            openFileDialog1.Dispose();
        }
    }
}
