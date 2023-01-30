

using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace Garage_Management.BAL.Implementation
{
    public class UserManagement:GMEntity<Employee>,IUserManagement
    {
        private readonly IConfiguration _configuration;

        public UserManagement(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Registeruser(Employee employee)
        {
            var connection = this.GetConnection();
            if (employee.LicenseNo == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            Employee IsUserExist = (await connection.QueryAsync<Employee>($"select * from employee where licenseno = '{employee.LicenseNo}'")).FirstOrDefault();

            if (IsUserExist != null)
            {
                throw new Exception(message: "Sorry..!, The LicenseNo is Already Exists");
            }

            var EmployeeId = this.AddorUpdate(employee);

            }
            
     }


    

    
}