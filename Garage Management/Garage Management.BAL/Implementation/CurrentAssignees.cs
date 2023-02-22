using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class CurrentAssignees:GMEntity<TruckSummary>, ICurrentAsignee
    {
        public CurrentAssignees()
        {

        }

        public async Task<TruckSummary> AddCurrentAssignees(TruckSummary truckSummary)
        {
            using var connection = this.GetConnection();
            truckSummary = await this.AddorUpdate(truckSummary);
            return truckSummary;
        }

        public async Task<List<Currentassignee>> GetSummaries()
        {
            using var connection = this.GetConnection();
            return (await connection.QueryAsync<Currentassignee>("select Employee.name as EName, * from  Trucksummary inner join garage on garage.id = trucksummary.garageid inner join Employee on employee.id = trucksummary.employeeid inner join Vehicle on vehicle.id = trucksummary.truckid")).ToList();
        }
    }
}
