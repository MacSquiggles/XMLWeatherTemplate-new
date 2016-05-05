/*Program by Quigley
    a weather "app" using xml files
    created April 28th 2016 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class ForecastForm1 : UserControl
    {
        //creates an object d
        Day d;

        //strings made to set the object properties equal to the correct info
        string clo, windDir, max, min, rain, wnd, press, condi;

        public ForecastForm1()
        {
            InitializeComponent();
        }

        private void ForcastForm_Load(object sender, EventArgs e)
        {
            //used to change the month int value to the month name
            System.Globalization.DateTimeFormatInfo mfi = new
            System.Globalization.DateTimeFormatInfo();

            //loads the xml document to be read
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");
            XmlNode parent;
            parent = doc.DocumentElement;

            //Displays the correct weather information
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "name")
                {
                    cityNameLabel.Text = child.Attributes["value"].Value + " Weather";
                }

                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "time")
                        {
                            if (grandChild.Attributes["day"].Value == MainMenu.days[ForecastMenu.numFore])
                            {
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        condi = greatGrandChild.Attributes["name"].Value;

                                        // choses an image to show based on the conditions
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) <= 232 && Convert.ToInt16(greatGrandChild.Attributes["number"].Value) >= 200)
                                        {
                                            weatherImage.Image = Properties.Resources.lightning;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) <= 321 && Convert.ToInt16(greatGrandChild.Attributes["number"].Value) >= 300)
                                        {
                                            weatherImage.Image = Properties.Resources.drizzle;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) <= 531 && Convert.ToInt16(greatGrandChild.Attributes["number"].Value) >= 500)
                                        {
                                            weatherImage.Image = Properties.Resources.rainicon;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) <= 622 && Convert.ToInt16(greatGrandChild.Attributes["number"].Value) >= 600)
                                        {
                                            weatherImage.Image = Properties.Resources.snow;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) <= 804 && Convert.ToInt16(greatGrandChild.Attributes["number"].Value) >= 801)
                                        {
                                            weatherImage.Image = Properties.Resources.cloudy;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) <= 957 && Convert.ToInt16(greatGrandChild.Attributes["number"].Value) >= 952)
                                        {
                                            weatherImage.Image = Properties.Resources.wind;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) == 800)
                                        {
                                            weatherImage.Image = Properties.Resources.sunicon;
                                        }
                                        if (Convert.ToInt16(greatGrandChild.Attributes["number"].Value) == 741)
                                        {
                                            weatherImage.Image = Properties.Resources.fog;
                                        }
                                    }
                                    if (greatGrandChild.Name == "precipitation")
                                    {
                                        try {
                                            rain = greatGrandChild.Attributes["value"].Value;
                                        }
                                        catch
                                        {
                                            rain = "0";
                                        }
                                    }
                                    if (greatGrandChild.Name == "pressure")
                                    {
                                        press = greatGrandChild.Attributes["value"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        max = greatGrandChild.Attributes["max"].Value;
                                        min = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        clo = greatGrandChild.Attributes["value"].Value;
                                    }
                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        wnd = Convert.ToString(Convert.ToDouble(greatGrandChild.Attributes["mps"].Value) * 3.6);
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDir = greatGrandChild.Attributes["code"].Value;
                                    }
                                }
                            }
                        }

                        //Creates a new day object containing the correct values
                        d = new Day(clo, max, min, rain, wnd, windDir, press, condi);

                        //Displays the correct date
                        if (ForecastMenu.numFore == 1)
                        {
                            nameLabel.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast1[1])) + " " + ForecastMenu.forecast1[2];
                        }
                        if (ForecastMenu.numFore == 2)
                        {
                            nameLabel.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast2[1])) + " " + ForecastMenu.forecast2[2];
                        }
                        if (ForecastMenu.numFore == 3)
                        {
                            nameLabel.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast3[1])) + " " + ForecastMenu.forecast3[2];
                        }
                        if (ForecastMenu.numFore == 4)
                        {
                            nameLabel.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast4[1])) + " " + ForecastMenu.forecast4[2];
                        }
                    }
                }
            }
            //Displays weather infor according to the object
            forecastMaxLabel.Text = "Max " + d.maxTemp + "°C";
            forecastMinLabel.Text = "Min " + d.minTemp + "°C";
            cloudsLabel.Text = d.clouds.Remove(1).ToUpper() + d.clouds.Substring(1);
            rainPerLabel.Text = d.rainPer + "%" + " chance of rain";
            pressureLabel.Text = "Pressure of " + d.pressure + "hKpa";
            windLabel.Text = d.windDir + " wind at " + d.wind + "km/h";
            conditionsLabel.Text = d.conditions.Remove(1).ToUpper() + d.conditions.Substring(1);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //if the exit button is clicked, the program closes
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //If the main menu button is clicked the main menu form opens
            ForecastMenu mm = new ForecastMenu();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
            mm.BringToFront();
        }
    }
}
