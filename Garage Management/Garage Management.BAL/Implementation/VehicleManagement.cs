using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class VehicleManagement : IVehicle
    {       
       
        public async Task AddorUpdateVehicle(Vehicle vehicle)
        {
            var a = new GMEntity<Vehicle>();
            using var connection = a.GetConnection();

            if(vehicle != null)
            {               
                 await a.AddorUpdate(vehicle);               
            }
            
        }

        public async Task<List<Vehicle>> GetAllVehicles()
        {
            var b = new GMEntity<Vehicle>();
            using var connection = b.GetConnection();
            var data =await connection.QueryAsync<Vehicle>($"select * from Vehicle");
            return data.ToList();
        }

        public async Task<MaintenanceSummary> AddMaintenanceSummary(MaintenanceSummary maintenanceSummary)
        {
            var entity = new GMEntity<MaintenanceSummary>();
            {
                var Id = await entity.AddorUpdate(maintenanceSummary); 
            }
            return maintenanceSummary;

        }

        public async Task<List<DashCount>> GetAllDashbord()
        {
            var entity = new GMEntity<MaintenanceSummary>();
            using var connection = entity.GetConnection();
            var data = await connection.QueryAsync<DashCount>($"SELECT * FROM vw_Dashboard_details JOIN vw_Vehicle_count ON 1 = 1;");
            return data.ToList();
        }

    }
}
