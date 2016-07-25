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

namespace ProductApplicationProject
{
    public partial class Product_Update_Form : Form
    {
        // sql variables
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        ConnectionClass conobj = new ConnectionClass();

        string query;


        public Product_Update_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // update command
            query = "update Product_tbl set Pname=@prm_Pname,Rate=@prm_Rate where Pno=@prm_Pno";

           cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("prm_Pno", textBox_pno.Text);
            cmd.Parameters.Add("prm_Pname", textBox_pname.Text);
            cmd.Parameters.Add("prm_Rate", textBox_rate.Text);

            cmd.ExecuteNonQuery();

            // close connection
            con.Close();

            MessageBox.Show(" Product Updated Sucessfully....");

            // clear textbox
            textBox_pno.Clear();
            textBox_pname.Clear();
            textBox_rate.Clear();
            textBox_pno.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // select command
            query = "select * from Product_tbl where Pno=@prm_Pno";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("prm_Pno", textBox_pno.Text);

            // read the command data
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox_pname.Text = dr["Pname"].ToString();
                textBox_rate.Text = dr["Rate"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Product Number....");
                textBox_pname.Clear();
                textBox_rate.Clear();
                textBox_pno.Focus();
            }

            dr.Close();
                      

            // close connection
            con.Close();

           
        }
    }
}
