using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;
using AlphaCert.RDS.Repository;
using Microsoft.Extensions.Logging;
using Alphacert.Acc.Ods.Entities.Entities;
using System.IO;
using System.Linq;
using Alphacert.Acc.Ods.Api.Models;

using Alphacert.Acc.Ods.Api.Services;
using Microsoft.Extensions.Options;

namespace Alphacert.Acc.Ods.Api.APIs.v2
{

    [Route("[controller]")]
    public class ODSDataController : Controller
    {
        private readonly IUnitOfWork<IDS_ODSContext> _unitOfWork;
        //private readonly IDS_ODSContext _unitOfWork;
        private ILogger<ODSDataController> _logger;
        private AppConfig _appConfig; 

        public ODSDataController(IUnitOfWork<IDS_ODSContext> unitOfWork,
               ILogger<ODSDataController> logger, IOptions<AppConfig> config)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _appConfig = config?.Value;
        }
        /// <summary>
        /// Get country data
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Get Succeeded</response>
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError)]
        [HttpGet("countries/{version}")]
        public async Task<IActionResult> GetCountries(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var list = await _unitOfWork.Repository<Country>().Query.All().AsEnumerableAsync();
            var data = list.Select(a => new ViewCountry {  Name = a.CountryName, Code = a.Iso2charCode, CurrencyCode = a.Currency});           
            return Json(data);
        }

        [HttpGet("currencies/{version}")]
        public async Task<IActionResult> GetCurrencies(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var list = await _unitOfWork.Repository<BbcurrencyMapping>().Query.All().AsEnumerableAsync();
            var data = list.Select(a => new ViewCurrency {  Code = a.Isocode, Name = a.CurrencyDescription });
            return Json(data);
        }
        
        [HttpGet("instruments/{version}")]
        public async Task<IActionResult> GetInstruments(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var list = await _unitOfWork.Repository<Instrument>().Query.All().AsEnumerableAsync();
            var data = list.Select(a => new ViewInstrument { InstrumentId = a.InstrumentId.ToString(), InstrumentName = a.InstrumentName,
                CurrencyCode = a.Currency, ExposureCurrencyCode = a.Currency });
            return Json(list);
        }
        
        /// <summary>
        /// vwValuationRelatedInstrument 
        /// </summary>
        /// <param name="version"></param>
        /// <param name="lastModified"></param>
        /// <returns></returns>        
        [HttpPost("valuations/{version}")]
        public async Task<IActionResult> GetValuation(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            new ValuationService(_appConfig.AppSettings.DBConnectionString).GetValuationData();
            return Created("valuationsdata", string.Empty);
        }
        
        [HttpGet("portfolios/{version}")]
        public async Task<IActionResult> GetPortfolios(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {
            var list = await _unitOfWork.Repository<Portfolio>().Query.All().AsEnumerableAsync();
            var data = list.Select(a => new ViewPortfolio
            {
                PortfolioId  = a.PortfolioId.ToString(), 
                PortfolioName = a.Name, 
                StrategyCode = a.AccfundCode, 
                FundKey = a.AccfundCode
            });
            return Json(data);
        }
                         
        [HttpGet("valuationsdata")]
        public async Task<IActionResult> GetPartialPortfolios(string version, [FromQuery(Name = "last-modified")]DateTime? lastModified = null)
        {            
            var path = Path.Combine(AppConstant.fileResourceFolder, AppConstant.fileResourceName);
            if (System.IO.File.Exists(path))
            {
                return File(System.IO.File.OpenRead(path), "text/plain");
            }
            else
            {
                return Accepted();
            }
        }
    }
}