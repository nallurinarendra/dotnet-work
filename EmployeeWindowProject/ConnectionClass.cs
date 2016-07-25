using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeWindowProject
{
    class ConnectionClass
    {
        // Connection Function
        public SqlConnection MyProjectConnection()
        {
            string strconn = ConfigurationManager.ConnectionStrings["ProjectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strconn);
            return con;
        }
    }
}
