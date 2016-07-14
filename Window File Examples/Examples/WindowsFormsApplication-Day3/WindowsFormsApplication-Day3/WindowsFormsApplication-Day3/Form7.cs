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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
            textBox3.Text = dateTimePicker1.Value.ToString("dd / MM / yyyy hh:mm:ss");
        }
    }
}
