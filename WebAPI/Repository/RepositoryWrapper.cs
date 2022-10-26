using Contracts;
using Contracts.Location;
using Contracts.WeatherForecast;
using Entities;
using Repository.Location;
using Repository.WeatherForecast;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ICountryRepository _country;
        private ICityRepository _city;
        private IWeatherLogRepository _weatherlogs;

        public ICountryRepository Country
        {
            get
            {
                if (_country == null)
                {
                    _country = new CountryRepository();
                }
                return _country;
            }
        }

        public ICityRepository City
        {
            get
            {
                if(_city == null)
                {
                    _city = new CityRepository();
                }
                return _city;
            }
        }

        public IWeatherLogRepository WeatherLogs
        {
            get
            {
                if (_weatherlogs == null)
                {
                    _weatherlogs = new WeatherLogRepository();
                }
                return _weatherlogs;
            }
        }

    }
}
