using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Contracts.WeatherForecast;
using LoggerService;

namespace WebAPI.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("api/weatherlogs")]
        public ActionResult GetWeatherBy(string cityid)
        {
            try
            {
                var result = _repository.WeatherLogs.GetWeatherBy(cityid);

                if (result.Count == 0)
                {
                    return NotFound(result);
                }
                else
                {
                    _logger.LogInfo(MessagesLog.GetWeatherLogByCityID);

                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(MessagesLog.ControllerError + nameof(GetWeatherBy) + " : " + ex.Message);
                return StatusCode(500, MessagesLog.IntSvrError);
            }
        }

    }
}
