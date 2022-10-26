using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.WeatherLogs;

namespace Contracts.WeatherForecast
{
    public interface IWeatherLogRepository
    {
        List<Entities.WeatherLogs.WeatherForecast> GetWeatherBy(string cityid);
    }
}
