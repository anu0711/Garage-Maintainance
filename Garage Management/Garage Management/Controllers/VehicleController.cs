using Garage_Management.Common.Interfaces;
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

        public async void AddorUpdateVehicle([FromBody] Vehicle vehicle)
        {
            await _vehicle.AddorUpdateVehicle(vehicle);

        }

        [HttpGet]
        
        public async Task<List<Vehicle>> GetAllvehicle()
        {
            return await _vehicle.GetAllVehicles();
        }

        [HttpPost]
        public async Task<MaintenanceSummary> MaintenanceSummary([FromBody] MaintenanceSummary maintenanceSummary)
        {
            return await _vehicle.AddMaintenanceSummary(maintenanceSummary);
        }

        [HttpGet]
        public async Task<List<MaintenanceSummaryDomain>> GetMaintainanceSummary()
        {
            return await _vehicle.GetMaintenanceSummary();
        }

        [HttpGet]
        public string GetVehicleCount()
        {
            return _vehicle.GetVehicleCount();
        }

    }
}
