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
    public partial class BanerForm : Form
    {
        public BanerForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value>=progressBar1.Maximum)
            {
                timer1.Stop();

                Form1 obj = new Form1();
                obj.Show();
                
                this.Hide();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }
    }
}
