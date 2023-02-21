﻿using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
   
    public class VehicleController : ControllerBase
    {
        private readonly IVehicle _vehicle;

        public VehicleController (IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        [HttpPost]

        public async Task<IActionResult> AddorUpdateVehicle([FromBody] Vehicle vehicle)
        {
            try
            {
               await _vehicle.AddorUpdateVehicle(vehicle);
                return Ok("Added/Updated Successfully");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        
        public async Task<List<Vehicle>> GetAllvehicle()
        {
            return await _vehicle.GetAllVehicles();
        }

        [HttpPost]
        public async Task<Spendings> MaintenanceSummary([FromBody] Spendings maintenanceSummary)
        {
            return await _vehicle.AddMaintenanceSummary(maintenanceSummary);
        }

       [HttpGet]
        public async Task<List<DashCount>> GetAllDashbord()
        {
            return await _vehicle.GetAllDashbord();
        }

        [HttpGet]

        public async Task<List<Vehicle>> GetByName(string VehicleName)
        {
            return await _vehicle.GetByName(VehicleName);
        }


    }
}
