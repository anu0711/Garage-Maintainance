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

        public User(IUserManagement usermanagement)
        {
            _usermanagement = usermanagement;
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
            catch(Exception E)
            {
                throw new Exception($"Something went wrong in Registraton");
            }
            
        }
    }
}