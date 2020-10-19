using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow,
            windSpeed, windDirection, precipitation, visibility;
        public Image icon;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility ="";
        }
    }
}
