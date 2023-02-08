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
        private readonly IBlob _blob;

        public VehicleManagement(IBlob blob)
        {
            _blob = blob;
        }
       
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



        public async Task<List<MaintenanceSummaryDomain>> GetMaintenanceSummary()
        {
            var entity = new GMEntity<MaintenanceSummary>();
            return (await entity.GetConnection().QueryAsync<MaintenanceSummaryDomain>("select * from MaintenanceSummary inner join Vehicle on Vehicle.Id = MaintenanceSummary.TruckId")).ToList();
        }
    }
}
