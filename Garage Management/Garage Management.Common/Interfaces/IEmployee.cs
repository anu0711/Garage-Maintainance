using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface IEmployee
    {
        Task AddOrUpdateEmployee(EmployeeSummary employeeSummary);

        Task<List<EmployeeSummary>> GetEmployeeSummaries();
    }
}
