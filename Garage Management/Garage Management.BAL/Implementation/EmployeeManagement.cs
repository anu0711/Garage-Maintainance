using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class EmployeeManagement : IEmployee
    {
        public async Task AddOrUpdateEmployee(EmployeeSummary employeeSummary)
        {
            var dbconnect = new GMEntity<EmployeeSummary>();
            using var connection = dbconnect.GetConnection();

            if(employeeSummary != null)
            {
                await dbconnect.AddorUpdate(employeeSummary);
            }
        }

        public async Task<List<EmployeeSummary>> GetEmployeeSummaries()
        {
            var dbconnect = new GMEntity<EmployeeSummary>();
            using var connection = dbconnect.GetConnection();
            var result = await connection.QueryAsync<EmployeeSummary>($"select * from employeesummary");
            return result.ToList();
        }
    }
}
