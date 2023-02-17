using Garage_Management.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class ReminderController : ControllerBase
    {

        private readonly IReminder _Reminder;
        public ReminderController(IReminder reminder)
        {
            _Reminder = reminder;
        }

        [HttpGet]
        public async Task<long> GetProfit()
        {
            return await _Reminder.GetProfit();
        }

        [HttpGet]
        public async Task<long> GetLoss()
        {
            return await _Reminder.GetLoss();
        }


    }
}
