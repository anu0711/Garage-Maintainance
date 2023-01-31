using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
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
    }
}
