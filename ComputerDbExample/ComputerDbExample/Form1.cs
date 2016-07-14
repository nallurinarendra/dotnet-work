using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerDbExample
{
    public partial class Form1 : Form
    {

        SqlConnection con = null;
        SqlCommand cmd = null;

       
        DataSet ds = new DataSet();


        String query = "";

        ConnectionClass conobj = new ConnectionClass();

        public Form1()
        {
            InitializeComponent();
            //open connection
            con = conobj.MyProjectConn();
            con.Open();

            query = " select pName from rate_tbl";

            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
          
            while (dr.Read())
            {
                string fil1 = dr.GetString(0);
                checkedListBox1.Items.Add(fil1);
            }
            dr.Close();

            con.Close();


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //open connection
            con = conobj.MyProjectConn();
            con.Open();

            query = "select pRate from rate_tbl where prm_pName=@prm_pName";

            string selectedItem = checkedListBox1.SelectedIndex.ToString();

            

            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                string fil1 = dr.GetString(0);
                checkedListBox1.Items.Add(fil1);
            }
            dr.Close();

            con.Close();

        }
    }
}
