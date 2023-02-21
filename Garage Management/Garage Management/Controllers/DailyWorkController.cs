﻿using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class DailyWorkController : ControllerBase
    {
        private readonly IDailyWorkSummary _dailyWorkSummary;

        public DailyWorkController(IDailyWorkSummary dailyWorkSummary)
        {
            _dailyWorkSummary = dailyWorkSummary;
        }

        [HttpPost]

        public async Task<IActionResult> AddorUpdateDailyWork([FromBody] DailyWorkSummary dailyWorkSummary)
        {
            try
            {
                await _dailyWorkSummary.AddorUpdateDailyWork(dailyWorkSummary);
                return Ok("Added/Updated Successfully");

            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]

        public async Task<List<DailyWorkSummary>>GetAllDailyWork()
        {
            return await _dailyWorkSummary.GetAllDailyWorkSummaries();
        }

        [HttpGet]

        public async Task<List<DailyWorkSummary>> GetDailyWorkById(Guid id)
        {
            return await _dailyWorkSummary.GetDailyWorkById(id);

        }

    }
}
