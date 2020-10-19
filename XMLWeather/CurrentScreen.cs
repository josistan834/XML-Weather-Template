using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        //Display daily information on the screen, and change the background acordingly
        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)) + "°C";
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[0].tempLow)) + "°";
            percipitationLabel.Text = Form1.days[0].precipitation + "%";
            windLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].windSpeed)) + "m/s";
            date.Text = Form1.days[0].date;
            //display the custom made image based on weather
            if (Convert.ToInt16(Form1.days[0].condition) < 600)
            {
                this.BackgroundImage = Properties.Resources.rainy;
            }
            else if (Convert.ToInt16(Form1.days[0].condition) < 700)
            {
                this.BackgroundImage = Properties.Resources.snowy;
            }
            else if (Convert.ToInt16(Form1.days[0].condition) > 800)
            {
                this.BackgroundImage = Properties.Resources.cloudy__2_;

            }
            else
            {
                this.BackgroundImage = Properties.Resources.sunny;
            }
        }

        //Go to the forcast screen on extend click
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        //Search for a city and retrieve the information
        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.city = inputBox.Text;
            Console.WriteLine(Form1.city);
            while(Form1.days.Count > 0)
            {
                Form1.days.RemoveAt(0);
            }
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
            DisplayCurrent();
            Refresh();

        }
    }
}
