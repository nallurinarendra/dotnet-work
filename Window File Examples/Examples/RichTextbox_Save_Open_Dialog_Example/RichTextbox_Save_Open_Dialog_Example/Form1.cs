using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextbox_Save_Open_Dialog_Example
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
            richTextBox1.Font = fontDialog1.Font;
            fontDialog1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
            colorDialog1.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format | *.rtf";

            saveFileDialog1.ShowDialog();

            string filename = saveFileDialog1.FileName;


            if (filename != "")
            {
                richTextBox1.SaveFile(filename);
            }

            saveFileDialog1.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text Format | *.rtf";


            openFileDialog1.ShowDialog();

            string filename = openFileDialog1.FileName;

            if (filename != "")
            {
                richTextBox1.LoadFile(filename);
            }

            openFileDialog1.Dispose();
        }
    }
}
