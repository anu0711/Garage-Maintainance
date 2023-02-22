using Garage_Management.BAL.Implementation;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrentAssigneeController : ControllerBase
    {
        private readonly ICurrentAsignee _currentassignee;
        public CurrentAssigneeController(ICurrentAsignee currentAsignee)
        {
            _currentassignee = currentAsignee;
        }

        [HttpPost]
        public async Task<TruckSummary> AddCurrentAssignees([FromBody]TruckSummary truckSummary)
        {
            return await _currentassignee.AddCurrentAssignees(truckSummary);
        }

        [HttpGet]
        public async Task<List<Currentassignee>> GetCurrentAssignees()
        {
            return await _currentassignee.GetSummaries();
        }
    }
}
