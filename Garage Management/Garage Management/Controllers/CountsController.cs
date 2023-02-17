using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class CountsController : ControllerBase
    {
        private readonly ICounts _counts;
        public CountsController(ICounts counts)
        {
            _counts = counts;
        }
        [HttpGet]
        public async Task<CountModel> Counts()
        {
            return await _counts.GetCounts();
        }

        [HttpGet]
        public async Task<List<Reminder>> GetBookings()
        {
            return await _counts.GetBookings();
        }
    }
}
