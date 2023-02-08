using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class TruckController : ControllerBase
    {
        private readonly ITruck _truck;

        public TruckController(ITruck truck)
        {
            _truck = truck;
        }

        [HttpPost]
        public async void AddOrUpdateTruck([FromBody] TruckSummary truckSummary)
        {
            await _truck.AddOrUpdateTruck(truckSummary);
        }

        [HttpGet]
        public async Task<List<TruckSummary>> GetAllTruckSummary()
        {
            return await _truck.GetTruckSummaries();
        }

        [HttpGet]
        public async Task<List<TruckSummary>> SearchTruck(string searchkey)
        {
            return await _truck.SearchTruck(searchkey);
        }
    }
}
