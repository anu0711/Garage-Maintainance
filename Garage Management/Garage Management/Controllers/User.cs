using Garage_Management.BAL.DomainModel;
using Garage_Management.BAL.Implementation;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class User : ControllerBase
    {
        private readonly IUserManagement _usermanagement;
        private readonly IAuthentication _authentication;
        public User(IUserManagement usermanagement, IAuthentication authentication)
        {
            _usermanagement = usermanagement;
            _authentication = authentication;
        }

        [HttpPost]
        public async void AddOrUpdateEmployee([FromBody] Employee employee)
        {
            await _usermanagement.Registeruser(employee);
        }

        [HttpPost]

        public async void LoginRegistration([FromBody] LoginModel register)
        {
            try
            {
                await _usermanagement.LoginRegister(register);

            }
            catch (Exception E)
            {
                throw new Exception(E.Message);
                throw new Exception(E.Message);
            }

        }

        [HttpPost]
        public async Task<string> Login([FromBody] LoginDetails loginDetails)
        {
            try
            {
                return await _authentication.Login(loginDetails);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        [HttpGet]
        public string GetEmployeeCount()
        {
            return _usermanagement.GetEmployeeCount();
        }

        [HttpGet]

        public async Task<List<Employee>> GetAllEmployee()
        {
            return await _usermanagement.GetAllEmployee();
        }

        [HttpGet]
        public async Task<Employee> GetBankDetails(Guid Id)
        {
            return await _usermanagement.GetBankDetails(Id);
        }

        [HttpGet]

        public async Task<List<Employee>> SearchEmployee(string searchkey)
        {
            return await _usermanagement.SearchEmployee(searchkey);
        }

        [HttpDelete]

        public async Task RemoveEmployee([FromBody] Employee employee)
        {
            await _usermanagement.DeleteEmployee(employee);
        }
    }
}