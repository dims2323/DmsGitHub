
namespace Contracts
{
    public interface IRepositoryWrapper
    {
        Location.ICountryRepository Country { get; }
        Location.ICityRepository City { get; }
        WeatherForecast.IWeatherLogRepository WeatherLogs { get; }
    }
}
