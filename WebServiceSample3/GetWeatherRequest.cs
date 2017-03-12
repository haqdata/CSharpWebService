using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample3
{
    public enum TemperatureType
    {
        Fahrenheit,
        Celsius
    }

    public enum TemperatureCondition
    {
        Rainy,
        Sunny,
        Cloudy,
        Thunderstorm
    }
    public class GetWeatherRequest
    {
        public string City { get; set; }
        public TemperatureType TemperatureType { get; set; }
    }
}