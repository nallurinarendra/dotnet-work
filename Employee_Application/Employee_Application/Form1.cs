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

namespace Employee_Application
{
    public partial class Form1 : Form
    {
        ConnectionClass conobj = new ConnectionClass();
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        SqlDataReader dr = null;
        DataSet ds = new DataSet();


        string query = "";

        void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert the Employee
            try
            {
                // Open Connection
                con = conobj.MyProjectConnection();
                con.Open();

                // Insert the query
                query = "insert into Employee_tbl values(@prm_Eno,@prm_Ename,@prm_Salary)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("prm_Eno", textBox1.Text);
                cmd.Parameters.Add("prm_Ename", textBox2.Text);
                cmd.Parameters.Add("prm_Salary", textBox3.Text);
                cmd.ExecuteNonQuery();

                // Close
                con.Close();

                MessageBox.Show(" Employee Inserted Sucessfully.....");

                ClearAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display all employee Details

            try
            {
                // open connection
                con = conobj.MyProjectConnection();
                con.Open();

                // Select query
                query = "select * from Employee_tbl";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Employee");

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();

                // Close Connection
                con.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                // open connection
                con = conobj.MyProjectConnection();
                con.Open();

                // Select query
                query = "select Ename,Salary from Employee_tbl where Eno=@prm_Eno";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("prm_Eno", textBox1.Text);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    textBox2.Text = dr["Ename"].ToString();
                    textBox3.Text = dr["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show(" Invalid Employee Number....");
                }
                dr.Close();

                // Close Connection
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update the Employee
            try
            {
                // Open Connection
                con = conobj.MyProjectConnection();
                con.Open();

                // Update the query
                query = "update Employee_tbl set Ename=@prm_Ename , Salary=@prm_Salary where Eno=@prm_Eno";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("prm_Eno", textBox1.Text);
                cmd.Parameters.Add("prm_Ename", textBox2.Text);
                cmd.Parameters.Add("prm_Salary", textBox3.Text);
                cmd.ExecuteNonQuery();

                // Close
                con.Close();

                MessageBox.Show(" Employee Update Sucessfully.....");

                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete the Employee
            try
            {
                // Open Connection
                con = conobj.MyProjectConnection();
                con.Open();

                // Delete the query
                query = "delete from Employee_tbl where Eno=@prm_Eno";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("prm_Eno", textBox1.Text);               
                cmd.ExecuteNonQuery();

                // Close
                con.Close();

                MessageBox.Show(" Employee Deleted Sucessfully.....");

                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
