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
        private static string connectionString = "Server=tcp:garagemanagement.database.windows.net,1433;Initial Catalog=Garagemanagement;Persist Security Info=False;User ID=Anuranjan;Password=Anu@123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
