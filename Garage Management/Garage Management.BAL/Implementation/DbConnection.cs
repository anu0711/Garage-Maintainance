using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public static class DbConnection
    {
        private static string connectionString = "Server=ANURANJAN\\SQLEXPRESS;Database=Node Garage management;Integrated Security=True;";
        public static IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
