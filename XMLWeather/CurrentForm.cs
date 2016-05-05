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
    public partial class CurrentForm : UserControl
    {
        //splits the current date to find the day and month only
        List<string> currentDate = MainMenu.days[0].Split('-').ToList<string>();

        public CurrentForm()
        {
            InitializeComponent();
        }

        private void CurrentForm_Load(object sender, EventArgs e)
        {
            //converts the month number to the month name and displays it to the name label
            System.Globalization.DateTimeFormatInfo mfi = new
            System.Globalization.DateTimeFormatInfo();
            nameLabel.Text = "It is " + mfi.GetMonthName(Convert.ToInt16(currentDate[1])) + " " + currentDate[2];


            //loads the xml file
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");
            XmlNode parent;
            parent = doc.DocumentElement;

            //finds the city name, temperature, clouds ect data and displays it to the coresponding labels
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                    cityLabel.Text = child.Attributes["name"].Value + " Weather";
                }
                if (child.Name == "temperature")
                {
                    currentTempLabel.Text = "It is " + child.Attributes["value"].Value + "°C";
                }
                if (child.Name == "clouds")
                {
                    cloudLabel.Text = child.Attributes["name"].Value;
                }
                if (child.Name == "weather")
                {
                    //based on the number value, an image is displayed according to the conditions
                    if (Convert.ToInt16(child.Attributes["number"].Value) <= 232 && Convert.ToInt16(child.Attributes["number"].Value) >= 200)
                    {
                        currentWeatherImage.Image = Properties.Resources.lightning;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) <= 321 && Convert.ToInt16(child.Attributes["number"].Value) >= 300)
                    {
                        currentWeatherImage.Image = Properties.Resources.drizzle;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) <= 531 && Convert.ToInt16(child.Attributes["number"].Value) >= 500)
                    {
                        currentWeatherImage.Image = Properties.Resources.rainicon;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) <= 622 && Convert.ToInt16(child.Attributes["number"].Value) >= 600)
                    {
                        currentWeatherImage.Image = Properties.Resources.snow;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) <= 804 && Convert.ToInt16(child.Attributes["number"].Value) >= 801)
                    {
                        currentWeatherImage.Image = Properties.Resources.cloudy;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) <= 957 && Convert.ToInt16(child.Attributes["number"].Value) >= 952)
                    {
                        currentWeatherImage.Image = Properties.Resources.wind;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) == 800)
                    {
                        currentWeatherImage.Image = Properties.Resources.sunicon;
                    }
                    if (Convert.ToInt16(child.Attributes["number"].Value) == 741)
                    {
                        currentWeatherImage.Image = Properties.Resources.fog;
                    }
                }
                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "direction")
                        {
                            windDirectLabel.Text = grandChild.Attributes["name"].Value + " wind";
                        }
                        if (grandChild.Name == "speed")
                        {
                            currentWindLabel.Text = Convert.ToString(Convert.ToDouble(grandChild.Attributes["value"].Value) * 3.6) + "km/h wind";
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //if the exit button is pressed, the program closes
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //if the main menu button is clicked, the main menu opens
            MainMenu mm = new MainMenu();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
            mm.BringToFront();
        }
    }
}
