using ProductStoreProcedureExample.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStoreProcedureExample
{
    public partial class Form1 : Form
    {
        BAL_Class obj = new BAL_Class();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // store the text box values to bal class variables
            obj.p_pno = Convert.ToInt32(textBox_pno.Text);
            obj.p_pname = textBox_Pname.Text;
            obj.p_rate = double.Parse(textBox_Prate.Text);

            // call the insert function
            obj.BAL_Insert();


            // Clear the textbox
            MessageBox.Show("Product Inserted Sucessfully.....");
            textBox_pno.Clear();
            textBox_Pname.Clear();
            textBox_Prate.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // store the text box values to bal class variables
            obj.p_pno = Convert.ToInt32(textBox_pno.Text);
            obj.p_pname = textBox_Pname.Text;
            obj.p_rate = double.Parse(textBox_Prate.Text);

            // call the insert function
            obj.BAL_Update();


            // Clear the textbox
            MessageBox.Show("Product Updated Sucessfully.....");
            textBox_pno.Clear();
            textBox_Pname.Clear();
            textBox_Prate.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // store the text box values to bal class variables
            obj.p_pno = Convert.ToInt32(textBox_pno.Text);
           

            // call the insert function
            obj.BAL_Delete();


            // Clear the textbox
            MessageBox.Show("Product Delete Sucessfully.....");
            textBox_pno.Clear();
            textBox_Pname.Clear();
            textBox_Prate.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds=obj.BAL_Display();

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_pno.Clear();
            textBox_Pname.Clear();
            textBox_Prate.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // store the text box values to bal class variables
            obj.p_pno = Convert.ToInt32(textBox_pno.Text);


            // call the find function
            obj.BAL_Find();

            textBox_Pname.Text = obj.p_pname.ToString();
            textBox_Prate.Text = obj.p_rate.ToString();


            
        }
    }
}
