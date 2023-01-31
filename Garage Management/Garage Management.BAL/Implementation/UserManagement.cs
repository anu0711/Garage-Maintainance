using Dapper;
using Garage_Management.BAL.DomainModel;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;

namespace Garage_Management.BAL.Implementation
{
    public class UserManagement: IUserManagement
    {
        public async Task Registeruser(Employee employee)
        {
            var a = new GMEntity<Employee>();
            using var connection = a.GetConnection();
            if (employee.LicenseNo == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            Employee IsUserExist = (await connection.QueryAsync<Employee>($"select * from employee where licenseno = '{employee.LicenseNo}'")).FirstOrDefault();

            if (IsUserExist != null)
            {
                throw new Exception(message: "Sorry..!, The LicenseNo is Already Exists");
            }

            var EmployeeId = a.AddorUpdate(employee);

        }

        public async Task LoginRegister(LoginModel register)
        {
            var b = new GMEntity<Employee>();
            var c = new GMEntity<LoginDetails>();
            using var connection = b.GetConnection();

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

                var Id = b.AddorUpdate(employee);

                var loginDetails = new LoginDetails();
                loginDetails.Password = register.Password;
                loginDetails.EmailId = register.EmailId;
                loginDetails.Name = register.Name;
                loginDetails.EmployeeId = Id.Result.Id;
                var id2 = c.AddorUpdate(loginDetails);
                
            }


        }

    }


    

    
}