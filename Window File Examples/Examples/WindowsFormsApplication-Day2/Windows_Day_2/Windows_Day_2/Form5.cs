using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Day_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // List class
            List<string> Courses = new List<string>();
            Courses.Add("Dotnet");
            Courses.Add("JAva");
            Courses.Add("c");
            Courses.Add("c++");
            Courses.Add("Android");

            // add the List class values into listbox

            foreach (string st in Courses)
            {
                comboBox1.Items.Add(st);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
