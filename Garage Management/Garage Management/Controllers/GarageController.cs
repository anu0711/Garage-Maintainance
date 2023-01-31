using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]

    public class GarageController : ControllerBase
    {
        private readonly IGarage _garage;

        public GarageController(IGarage garage)
        {
            _garage = garage;
        }

        [HttpPost]

        public async void AddorUpdateGarage([FromBody] Garage garage)
        {
            await _garage.AddorUpdateGarage(garage);
        }

        [HttpGet]
        public async Task<List<Garage>> GetAllGarage()
        {
            return await _garage.GetGarages();
        }
    }
}
