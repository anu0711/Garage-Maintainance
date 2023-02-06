﻿using Dapper;
using Garage_Management.BAL.DomainModel;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;

namespace Garage_Management.BAL.Implementation
{
    public class UserManagement:GMEntity<Employee>, IUserManagement
    {
        public async Task Registeruser(Employee employee)
        {
            using var connection = this.GetConnection();
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

        public async Task LoginRegister(LoginModel register)
        {
            
            var c = new GMEntity<LoginDetails>();

            if(register != null)
            {
                var employee = new Employee();
                employee.Name = register.Name;
                employee.LicenseNo = register.LicenseNo;
                employee.IdNumber = register.IdNumber;
                employee.MobileNumber = register.MobileNumber;
                employee.Address = register.Address;
                employee.AccountNumber = register.AccountNumber;
                employee.Age = register.Age;
                employee.BankName = register.BankName;
                employee.Branch = register.Branch;
                employee.IFSC = register.IFSC;
                employee.IdType = register.IdType;

                var Id = this.AddorUpdate(employee);

                var loginDetails = new LoginDetails();
                loginDetails.Password = this.GeneratePassword(10);
                loginDetails.EmailId = register.EmailId;
                loginDetails.EmployeeId = Id.Result.Id;
                var id2 = c.AddorUpdate(loginDetails);
                
            }

        }   

        public async Task<List<Employee>> GetAllEmployee()
        {
            using var connection = this.GetConnection();
            var data = await connection.QueryAsync<Employee>($"select * from Employee");
             return data.ToList();
        }

        public string GetEmployeeCount()
        {
            using var connection = this.GetConnection();
            var data = connection.Query($"select count(*)  as Garagecount from employee").FirstOrDefault();
            return data.Garagecount.ToString();
        }
    

        public async Task<List<Employee>> SearchEmployee(string searchkey)
        {
            try
            {
                using var connection = this.GetConnection();
                return (List<Employee>)await connection.QueryAsync<Employee>($"select * from Employee where name LIKE '%{searchkey}%'");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<Employee> GetBankDetails(Guid id)
        {
            try
            {
                var connection = this.GetConnection();
                var result = (await connection.QueryAsync<Employee>($"select * from employee where id = '{id}'")).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }


    

    
}