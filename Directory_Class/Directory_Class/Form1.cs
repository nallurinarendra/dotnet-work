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

namespace Directory_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the all driectory that c / d drives 
            string[] st = Directory.GetLogicalDrives();
            foreach (string s in st)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // floders list
            listBox1.Items.Clear();
            string[] st = Directory.GetDirectories(comboBox1.SelectedItem.ToString());
            foreach (string s in st)
                listBox1.Items.Add(s);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // folder information files
            
            listBox2.Items.Clear();
            string[] st = Directory.GetFiles(listBox1.SelectedItem.ToString());
            foreach (string s in st)
                listBox2.Items.Add(s);
        }
    }
}
