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

    public partial class Product_Details_Form : Form
    {

        // sql variables
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = new DataSet();

        ConnectionClass conobj = new ConnectionClass();

        string query;

        
        public Product_Details_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // select command
            query = "select * from Product_tbl";
            cmd = new SqlCommand(query, con);

            // store teh command data in data abapter.
            da = new SqlDataAdapter(cmd);

            // Fill the da data in dataset
            ds = new DataSet();            
            da.Fill(ds, "Product");


            // assign the data set to gridview
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();         

           
            // close connection
            con.Close();

                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
