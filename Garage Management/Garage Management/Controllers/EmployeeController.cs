using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }   

        [HttpPost]

        public async void AddOrUpdateEmployeesummary([FromBody] EmployeeSummary employeeSummary)
        {
            await _employee.AddOrUpdateEmployee(employeeSummary);
        }

        [HttpGet]
        public async Task<List<EmployeeSummary>>GetAllEmployeesummary()
        {
            return await _employee.GetEmployeeSummaries();
        }

        [HttpGet]

        public async Task<List<EmployeeSummary>> GetSummaryById(Guid Id)
        {
            return await _employee.GetSummaryById(Id);
        }
    }
}
