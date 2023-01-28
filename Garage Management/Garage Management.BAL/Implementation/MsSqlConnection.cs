using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class MsSqlConnection : GMEntity<Vehicle>, Itest
    { 
        public async Task<string> Sample()
        {
            var connection = this.GetConnection();
            connection.Execute("CREATE TABLE customers (id INT PRIMARY KEY, first_name VARCHAR(255) NOT NULL,last_name VARCHAR(255) NOT NULL,email VARCHAR(255) NOT NULL);");
            return "";
        }
    }
}
