using Entities.WeatherLogs;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace Repository.DataSample
{
    public class WeatherForecastData
    {
        public static readonly List<Entities.WeatherLogs.WeatherForecast> WeatherDataSample = new List<Entities.WeatherLogs.WeatherForecast>()
        {
            new Entities.WeatherLogs.WeatherForecast() {
                ID = new Guid("1375054C-0DC3-4592-84CE-064274042A6B"),
                City_id = "204",
                Date = DateTime.ParseExact("2022-10-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Time= new TimeSpan(9, 00, 00),
                TemperatureC = 27,
                Dew_point = 0,
                Relative_Humidity = 0,
                Pressure = 0
            },
            new Entities.WeatherLogs.WeatherForecast() {
                ID = new Guid("F53C4C2D-8965-4BC4-8408-065AC2920D61"),
                City_id = "204",
                Date = DateTime.ParseExact("2022-10-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Time= new TimeSpan(9, 00, 00),
                TemperatureC = 27,
                Dew_point = 0,
                Relative_Humidity = 0,
                Pressure = 0
            },
            new Entities.WeatherLogs.WeatherForecast() {
                ID = new Guid("69B8589F-48A5-4A47-AB4A-08710FFDC14F"),
                City_id = "204",
                Date = DateTime.ParseExact("2022-10-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Time= new TimeSpan(9, 00, 00),
                TemperatureC = 27,
                Dew_point = 0,
                Relative_Humidity = 0,
                Pressure = 0
            }

        };

    }
}
