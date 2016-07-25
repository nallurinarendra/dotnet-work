using Libraryy3TierApplication.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraryy3TierApplication
{
    public partial class Form1 : Form
    {

        // create the bal class object
        BAL_Class obj = new BAL_Class();

        // clear all textbox and focus the currosr in rano text box
        void ClearALL()
        {
            textBox_rackno.Clear();
            textBox_BookName.Clear();
            textBox_AuthoName.Clear();
            textBox_rackno.Focus();

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            // Assign the textbox values to bal class variables
            obj.rno = int.Parse(textBox_rackno.Text);
            obj.bname = textBox_BookName.Text;
            obj.aname = textBox_AuthoName.Text;

            // call the insert function
            obj.Bal_Insert_Book();

            MessageBox.Show("Book Inserted Sucessfully....");

            // call the clear all function
            ClearALL();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            // Assign the textbox values to bal class variables
            obj.rno = int.Parse(textBox_rackno.Text);
            obj.bname = textBox_BookName.Text;
            obj.aname = textBox_AuthoName.Text;

            // call the update function
            obj.Bal_Update_Book();

            MessageBox.Show("Book Update Sucessfully....");

            // call the clear all function
            ClearALL();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            // Assign the textbox values to bal class variables
            obj.rno = int.Parse(textBox_rackno.Text);
                      

            // call the Delete function
            obj.Bal_Delete_Book();

            MessageBox.Show("Book Deleted Sucessfully....");

            // call the clear all function
            ClearALL();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = obj.Bal_Select_Books();

            dataGridView_Libaray.DataSource = ds.Tables[0];
            dataGridView_Libaray.Refresh();

        }

        private void dataGridView_Libaray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Libaray.Rows[e.RowIndex];

                textBox_rackno.Text = row.Cells["RackNo"].Value.ToString();
                textBox_BookName.Text= row.Cells["BookName"].Value.ToString();
                textBox_AuthoName.Text= row.Cells["AuthorName"].Value.ToString();

            }
        }
    }
}
