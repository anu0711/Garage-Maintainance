using Garage_Management.BAL.DomainModel;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface IUserManagement
    {
        Task Registeruser(Employee employee);

        Task LoginRegister(LoginModel register);

        Task<List<Employee>> GetAllEmployee();

        Task<List<Employee>> SearchEmployee(string searchkey);
    }
}
