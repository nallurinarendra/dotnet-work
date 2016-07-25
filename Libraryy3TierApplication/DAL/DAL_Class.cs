using Libraryy3TierApplication.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Libraryy3TierApplication.DAL
{
    class DAL_Class
    {
        // sql variables
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = new DataSet();

        // query variable
        string query = "";

        // create the connection class object
        ConnectionClass conobj = new ConnectionClass();

        public void Dal_Insert_Book(BAL_Class obj)
        {

            // opne Connection
            con = conobj.MyProjectConnection();
            con.Open();


            // Write the insert query
            query = "insert into Books_tbl values(@prm_RackNo,@prm_BookName,@prm_AuthorName)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("prm_RackNo", obj.rno);
            cmd.Parameters.Add("prm_BookName", obj.bname);
            cmd.Parameters.Add("prm_AuthorName", obj.aname);
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();

        }

        public void Dal_Update_Book(BAL_Class obj)
        {

            // opne Connection
            con = conobj.MyProjectConnection();
            con.Open();


            // Write the update query
            
            query = "update Books_tbl set BookName=@prm_BookName,AuthorName=@prm_AuthorName where RackNo=@prm_RackNo";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("prm_RackNo", obj.rno);
            cmd.Parameters.Add("prm_BookName", obj.bname);
            cmd.Parameters.Add("prm_AuthorName", obj.aname);
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();

        }

        public void Dal_Delete_Book(BAL_Class obj)
        {

            // opne Connection
            con = conobj.MyProjectConnection();
            con.Open();


            // Write the Delete query
            query = "delete from Books_tbl where RackNo=@prm_RackNo";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("prm_RackNo", obj.rno);           
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();

        }

        public DataSet Dal_Select_Books()
        {

            // opne Connection
            con = conobj.MyProjectConnection();
            con.Open();


            // Write the select query
            query = "select * from Books_tbl";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Books");

            // return data set
            return ds;

        }



    }
}
