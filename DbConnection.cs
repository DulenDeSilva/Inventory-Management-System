using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class DbConnection
    {
        private static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dulen\source\repos\IMS\IMS\Database1.mdf;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            return conn;
        } 



    }
}
