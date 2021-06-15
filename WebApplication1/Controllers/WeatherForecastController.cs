using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return new WeatherForecast[]
            {
                new WeatherForecast {Date =DateTime.Now, Summary = "Get", TemperatureC = 25}
            };
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Get2()
        {
            return new WeatherForecast[]
            {
                new WeatherForecast {Date =DateTime.Now, Summary = "Post", TemperatureC = 5}
            };
        }

        [HttpPut]
        public IEnumerable<WeatherForecast> Get3()
        {
            return new WeatherForecast[]
            {
                new WeatherForecast {Date =DateTime.Now, Summary = "Put", TemperatureC = 5}
            };
        }
    }
}
