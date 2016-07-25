using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductStoreProcedureExample.BAL;
using System.Data;

namespace ProductStoreProcedureExample.DAL
{
    class DAL_Class
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter da = null;
        ConnectionClass conobj = new ConnectionClass();

        string query;

        public void DAL_Insert(BAL_Class obj)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // query
            query = "insert_product";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@prm_pno", obj.p_pno);
            cmd.Parameters.Add("@prm_pname", obj.p_pname);
            cmd.Parameters.Add("@prm_prate", obj.p_rate);
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();
        }

        public void DAL_Update(BAL_Class obj)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // query
            query = "Update_product";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@prm_pno", obj.p_pno);
            cmd.Parameters.Add("@prm_pname", obj.p_pname);
            cmd.Parameters.Add("@prm_prate", obj.p_rate);
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();
        }

        public void DAL_Delete(BAL_Class obj)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // query
            query = "Delete_product";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@prm_pno", obj.p_pno);           
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();
        }


        public DataSet DAL_Display()
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // query
            query = "Display_productDetails";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");

            return ds;
            
        }

        public void DAL_Find(BAL_Class obj)
        {
            // open connection
            con = conobj.MyProjectConnection();
            con.Open();

            // query
            query = "Find_product";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@prm_pno",obj.p_pno);

            cmd.Parameters.Add("@prm_pname",SqlDbType.VarChar,500);
            cmd.Parameters["@prm_pname"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@prm_prate",SqlDbType.Money);
            cmd.Parameters["@prm_prate"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            obj.p_pname= cmd.Parameters["@prm_pname"].Value.ToString();
            obj.p_rate = double.Parse(cmd.Parameters["@prm_prate"].Value.ToString());


            // close connection
            con.Close();
        }



    }
}
