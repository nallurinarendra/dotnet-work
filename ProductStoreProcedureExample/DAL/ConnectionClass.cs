using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ProductStoreProcedureExample.DAL
{
    class ConnectionClass
    {
        public SqlConnection MyProjectConnection()
        {
            string strconn = ConfigurationManager.ConnectionStrings["ProjectConnection"].ToString();
            SqlConnection con = new SqlConnection(strconn);
            return con;
        }
    }
}
