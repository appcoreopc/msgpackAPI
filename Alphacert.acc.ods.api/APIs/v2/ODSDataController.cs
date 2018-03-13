using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alphacert.Acc.Ods.Entities;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;
using AlphaCert.RDS.Repository;
using Microsoft.Extensions.Logging;

namespace Alphacert.Acc.Ods.Api.APIs.v2
{

    [Route("[controller]")]
    public class ODSDataController : Controller
    {        
        private readonly IUnitOfWork<IDS_ODSContext> _unitOfWork;
        private ILogger<ODSDataController> _logger;
        
        public ODSDataController(IUnitOfWork<IDS_ODSContext> unitOfWork,
               ILogger<ODSDataController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get country data
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Get Succeeded</response>

        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError)]
        public IEnumerable<string> Get()
        {

            

            return new string[] { "value1", "value2" };
        }

        [HttpGet("countries/{version}")]
        public async Task<IActionResult> GetCountries(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var result = "countries";
            return Json(result);
        }

        [HttpGet("currencies/{version}")]
        public async Task<IActionResult> GetCurrencies(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var result = "";
            return Json(result);
        }


        [HttpGet("instruments/{version}")]
        public async Task<IActionResult> GetInstruments(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var result = "instrument";
            return Json(result);
        }


        [HttpGet("valuations/{version}")]

        public async Task<IActionResult> GetValuation(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var result = "valuations";
            return Json(result);
        }


        [HttpGet("portfolios/{version}")]
        public async Task<IActionResult> GetPortfolios(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var result = "portfolio";
            return Json(result);
        }
    }
}