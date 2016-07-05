using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainersToolBoxExample
{
    public partial class PanelExample : Form
    {
        public PanelExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }
    }
}
