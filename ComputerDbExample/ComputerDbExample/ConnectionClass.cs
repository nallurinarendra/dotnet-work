using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace ComputerDbExample
{
    class ConnectionClass
    {
        public SqlConnection MyProjectConn()
        {
            string strconn = ConfigurationManager.ConnectionStrings["MyProjectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strconn);
            return con;

         }

    }
}
