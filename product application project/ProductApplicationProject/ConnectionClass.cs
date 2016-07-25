using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace ProductApplicationProject
{
    class ConnectionClass
    {

        // connection function
        public SqlConnection MyProjectConnection()
        {
            string strconn = ConfigurationManager.ConnectionStrings["ProductConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strconn);
            return con;
        }
    }
}
