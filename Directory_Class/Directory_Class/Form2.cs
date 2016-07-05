using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_Class
{
    public partial class Form2 : Form
    {
        string path = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text.Trim();
                DirectoryInfo di = new DirectoryInfo(path);
                DirectoryInfo[] d = di.GetDirectories();
                listBox1.Items.Clear();
                foreach (DirectoryInfo d1 in d)
                    listBox1.Items.Add(d1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string st = path + "/" + listBox1.SelectedItem.ToString();
            DirectoryInfo di1 = new DirectoryInfo(st);
            FileInfo[] d2 = di1.GetFiles();
            foreach (FileInfo d1 in d2)
                listBox2.Items.Add(d1);
        }
    }
}
