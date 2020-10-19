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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        //Display the forcast for the week and change image/ icons acordingly
        public void displayForecast()
        {
            cityOutput.Text = Form1.days[0].location;
            temp1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[1].tempLow)) + "°";
            temp2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[2].tempLow)) + "°";
            temp3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[3].tempLow)) + "°";
            temp4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[4].tempLow)) + "°";
            temp5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[5].tempLow)) + "°";
            temp6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh)) + "°/ " + Math.Round(Convert.ToDouble(Form1.days[6].tempLow)) + "°";
            date1.Text = Form1.days[1].date;
            date2.Text = Form1.days[2].date;
            date3.Text = Form1.days[3].date;
            date4.Text = Form1.days[4].date;
            date5.Text = Form1.days[5].date;
            date6.Text = Form1.days[6].date;
            foreach (Day d in Form1.days)
            {
                if (Convert.ToInt16(d.condition) < 600)
                {
                    d.icon = Properties.Resources.rainIco;
                }
                else if (Convert.ToInt16(d.condition) < 700)
                {
                    d.icon = Properties.Resources.snowIco;
                }
                else if (Convert.ToInt16(d.condition) > 800)
                {
                    d.icon = Properties.Resources.cloudIco;

                }
                else
                {
                    d.icon = Properties.Resources.sunIco;
                }
            }
            //display custom image based on weather
            if (Convert.ToInt16(Form1.days[1].condition) < 600)
            {
                this.BackgroundImage = Properties.Resources.rainy;
            }
            else if (Convert.ToInt16(Form1.days[1].condition) < 700)
            {
                this.BackgroundImage = Properties.Resources.snowy;
            }
            else if (Convert.ToInt16(Form1.days[1].condition) > 800)
            {
                this.BackgroundImage = Properties.Resources.cloudy__2_;
            
            }
            else
            {
                this.BackgroundImage = Properties.Resources.sunny;
            }
            pictureBox1.BackgroundImage = Form1.days[1].icon;
            pictureBox2.BackgroundImage = Form1.days[2].icon;
            pictureBox3.BackgroundImage = Form1.days[3].icon;
            pictureBox4.BackgroundImage = Form1.days[4].icon;
            pictureBox5.BackgroundImage = Form1.days[5].icon;
            pictureBox6.BackgroundImage = Form1.days[6].icon;


        }

        //Return to Current screen on back click
        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
