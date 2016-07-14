using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace productApplicationproject
{
    public partial class AddProduct : Form
    {

        // sql variables
        SqlConnection con = null;
        SqlCommand cmd = null;

        ConnectionClass conobj = new ConnectionClass();

        string query;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //open connection
            con = conobj.Myprojectconnection();
            con.Open();


            //insert command
            query = "insert into pDetailsTable values(@prm_pName,@prm_pNo, @prm_pRate) ";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("prm_pName", textBox1.Text);
            cmd.Parameters.Add("prm_pNo", textBox2.Text);
            cmd.Parameters.Add("prm_pRate", textBox3.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("New product added successfully");

            //clear text boxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            textBox1.Focus();


            con.Close();

        }
    }
}
