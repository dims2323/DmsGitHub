using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Contracts.Location;
using LoggerService;

namespace WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public LocationController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("api/location/country")]
        public ActionResult GetCountryAll()
        {
            try
            {
                var result = _repository.Country.GetCountry();

                if (result.Count == 0)
                {
                    return NotFound(result);
                }
                else
                {
                    _logger.LogInfo(MessagesLog.GetCitiesByID);

                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(MessagesLog.ControllerError + nameof(GetCountryAll) + " : " + ex.Message);
                return StatusCode(500, MessagesLog.IntSvrError);
            }
        }

        [HttpGet]
        [Route("api/location/city")]
        public ActionResult GetCities(string countryid)
        {
            try
            {
                var result = _repository.City.GetCityBy(countryid);

                if (result.Count == 0)
                {
                    return NotFound(result);
                }
                else
                {
                    _logger.LogInfo(MessagesLog.GetCitiesByID);

                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(MessagesLog.ControllerError + nameof(GetCities) + " : " + ex.Message);
                return StatusCode(500, MessagesLog.IntSvrError);
            }
        }

    }
}
