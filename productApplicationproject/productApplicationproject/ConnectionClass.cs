using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace productApplicationproject
{
    class ConnectionClass
    {

        public SqlConnection Myprojectconnection()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["ProductConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(sqlconn);
            return con;
        }

    }
}
