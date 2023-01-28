using Garage_Management.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Garage_Management.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Itest _itest;

        public WeatherForecastController(Itest itest)
        {
            _itest = itest;
        }


        [HttpGet]
        public async Task<string> Sample()
        {
            return await _itest.Sample();
        }
    }
}