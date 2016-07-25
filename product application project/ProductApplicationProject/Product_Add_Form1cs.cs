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
    public partial class Product_Add_Form1cs : Form
    {
        // sql variables
        SqlConnection con = null;
        SqlCommand cmd = null;

        ConnectionClass conobj = new ConnectionClass();

        string query;


        public Product_Add_Form1cs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // insert command
            query = "insert into Product_tbl values(@prm_Pno,@prm_Pname,@prm_Rate)";

          //  query = "insert into Product_tbl values("+textBox_pno.Text+",'"+textBox_pname.Text+"',"+textBox_rate.Text+")";

            cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("prm_Pno", textBox_pno.Text);
            cmd.Parameters.Add("prm_Pname", textBox_pname.Text);
            cmd.Parameters.Add("prm_Rate", textBox_rate.Text);

            cmd.ExecuteNonQuery();

            // close connection
            con.Close();

            MessageBox.Show(" New Product Add Sucessfully....");

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
    }
}
