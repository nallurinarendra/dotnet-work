using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Employee_Application
{
    class ConnectionClass
    {
        // connection function

        public SqlConnection MyProjectConnection()
        {
            string connectionpath = ConfigurationManager.ConnectionStrings["EmployeeConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionpath);
            return con;
        }



    }
}
