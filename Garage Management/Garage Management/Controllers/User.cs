using Garage_Management.BAL.DomainModel;
using Garage_Management.BAL.Implementation;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
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
        public async Task<IActionResult> AddOrUpdateEmployee([FromBody] Employee employee)
        {
            try
            {
                await _usermanagement.Registeruser(employee);
                return Ok("Added/Updated Successfully");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> LoginRegistration([FromBody] LoginModel register)
        {
            try
            {
                await _usermanagement.LoginRegister(register);
                return Ok("Added/Updated Successfully");

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
        public async Task<List<Employeedomainmodel>> GetAllEmployee()
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

        [HttpGet]

        public async Task<List<Employee>> GetById (Guid Id)
        {
            return await _usermanagement.GetById(Id);
        }
    }
}