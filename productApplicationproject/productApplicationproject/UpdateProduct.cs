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
using System.Configuration;

namespace productApplicationproject
{
    public partial class UpdateProduct : Form
    {
        //sql variables
        SqlConnection con = null;
        SqlCommand cmd = null;

        string query;

        ConnectionClass conobj = new ConnectionClass();

        public UpdateProduct()
        {
            InitializeComponent();
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open the connection
            con = conobj.Myprojectconnection();
            con.Open();

            //update query
            // query = "update pDetailsTable set @prm_pName = pName, @prm_pRate = pRate where pNo = @prm_pNo";
            query = "update pDetailsTable set pName=@prm_pName,pRate=@prm_pRate where pNo=@prm_pNo";

            cmd = new SqlCommand(query, con);


            cmd.Parameters.Add("prm_pName", textBox1.Text);
            cmd.Parameters.Add("prm_pNo", textBox2.Text);
            cmd.Parameters.Add("prm_pRate", textBox3.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("details updated successfully...");
            con.Close();

        }
    }
}
