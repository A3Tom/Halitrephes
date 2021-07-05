using Halitrephes.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Halitrephes.Api.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class DataPointController : ControllerBase
    {
        private readonly ILogger<DataPointController> _logger;

        public DataPointController(ILogger<DataPointController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetStaticPoints()
        {
            var result = new List<StaticDataPointVM>();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetDynamicDataPoints()
        {
            var result = new List<DynamicDataPointVM>();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetDataPointGeoLocationHistory()
        {
            var result = new List<GeoLocationVM>();

            return Ok(result);
        }
    }
}
