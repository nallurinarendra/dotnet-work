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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();

            //for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            //{
            //    listBox1.Items.Add(checkedListBox1.CheckedItems[i].ToString());
            //}
        }

        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i].ToString());
            }
        }
    }
}
