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

namespace EmployeeWindowProject
{
    public partial class Form1 : Form
    {

        SqlConnection con = null;
        SqlCommand cmd = null;

        ConnectionClass con_obj = new ConnectionClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open connection 
            con = con_obj.MyProjectConnection();
            con.Open();

            // Insert query command
            string query = "insert into Employee_tbl values(@prm_eno,@prm_ename,@prm_salary)"; // insert query

            // Connect to query to connection 
            cmd = new SqlCommand(query, con);

            // assign command  paramenters values
            cmd.Parameters.Add("prm_eno", textBox_eno.Text);
            cmd.Parameters.Add("prm_ename", textBox_ename.Text);
            cmd.Parameters.Add("prm_salary", textBox_salary.Text);

            // Execute the query
            cmd.ExecuteNonQuery();


            // close connection
            con.Close();

            // display the message box and clear the textbox values.
            MessageBox.Show("Employee Details Inserted Sucessfully....");

            textBox_eno.Clear();
            textBox_ename.Clear();
            textBox_salary.Clear();
            textBox_eno.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
