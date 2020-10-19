using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();
        public static string LastUpdate, city;
        

        public Form1()
        {
            //Sets default city
            city = "stratford,CA";
            InitializeComponent();

            //Run to get info
            ExtractForecast();
            ExtractCurrent();
            
            //open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        //Retrieve information about weather for the city throughout a week
        public static void ExtractForecast()
        {
            try
            {
                XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={city}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

                while (reader.Read())
                {
                    //create a day object
                    Day newDay = new Day();

                    //fill day object with required data
                    reader.ReadToFollowing("time");
                    newDay.date = reader.GetAttribute("day");
                    reader.ReadToFollowing("symbol");
                    newDay.condition = reader.GetAttribute("number");
                    reader.ReadToFollowing("temperature");
                    newDay.tempLow = reader.GetAttribute("min");
                    newDay.tempHigh = reader.GetAttribute("max");

                    //if day object not null add to the days list
                    if (newDay != null)
                    {
                        days.Add(newDay);
                    }

                }
            }
            catch
            {
                city = "Stratford,CA";
                ExtractForecast();
            }
        }

        //Find day specific weather information
        public static void ExtractCurrent()
        {
            try
            {
                // current info is not included in forecast file so we need to use this file to get it
                XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

                //find the city and current temperature and add to appropriate item in days list
                reader.ReadToFollowing("city");
                days[0].location = reader.GetAttribute("name");
                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");
                reader.ReadToFollowing("wind");
                reader.ReadToDescendant("speed");
                days[0].windSpeed = reader.GetAttribute("value");
                reader.ReadToFollowing("precipitation");
                if (reader.GetAttribute("mode") == "no")
                {
                    days[0].precipitation = "0";
                }
                else
                {
                    days[0].precipitation = reader.GetAttribute("value");
                }
                reader.ReadToFollowing("weather");
                days[0].condition = reader.GetAttribute("number");
                reader.ReadToFollowing("lastupdate");
                LastUpdate = reader.GetAttribute("value");
            }
            catch
            {
                city = "Stratford,CA";
                ExtractCurrent();
            }
        }


    }
}
