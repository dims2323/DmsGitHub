using Contracts;
using Contracts.WeatherForecast;
using Entities;
using Entities.WeatherLogs;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Repository.WeatherForecast
{
    public class WeatherLogRepository : IWeatherLogRepository
    {
        public WeatherLogRepository()
        {
        }

        //Get weather data By city ID
        public List<Entities.WeatherLogs.WeatherForecast> GetWeatherBy(string cityid)
        {
            List<Entities.WeatherLogs.WeatherForecast> data = 
                (from x in DataSample.WeatherForecastData.WeatherDataSample
                               where x.City_id == cityid
                               select x).ToList();

            return data;
        }

    }
}
