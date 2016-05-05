using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    //An object day that uses the values clouds, windDir, maxTemp, minTemp, rainPer, wind, pressure, conditions
    //To correctly display the weather info
    class Day
    {
        public string clouds, windDir, maxTemp, minTemp, rainPer, wind, pressure, conditions;

        public Day(string _clouds, string _maxTemp, string _minTemp, string _rainPer, string _wind,  string _windDir, string _pressure, string _conditions)
        {
            clouds = _clouds;
            windDir = _windDir;
            maxTemp = _maxTemp;
            minTemp = _minTemp;
            rainPer = _rainPer;
            wind = _wind;
            pressure = _pressure;
            conditions = _conditions;
        }
    }
}
