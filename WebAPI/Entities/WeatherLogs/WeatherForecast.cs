using System;

namespace Entities.WeatherLogs
{
    public class WeatherForecast
    {
        public Guid ID { get; set; }
        public string City_id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public int Dew_point { get; set; }
        public int Relative_Humidity { get; set; }
        public int Pressure { get; set; }
    }
}
