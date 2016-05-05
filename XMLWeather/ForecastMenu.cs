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
    public partial class ForecastMenu : UserControl
    {
        //Creates a number to keep track of the day that can be used to access the list
        public static int numFore;

        //splits the string of what day it is in order to only display the month and day
        public static List<string> forecast1 = MainMenu.days[1].Split('-').ToList<string>();
        public static List<string> forecast2 = MainMenu.days[2].Split('-').ToList<string>();
        public static List<string> forecast3 = MainMenu.days[3].Split('-').ToList<string>();
        public static List<string> forecast4 = MainMenu.days[4].Split('-').ToList<string>();

        public ForecastMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //if the exit button is pressed, the program closes
            Application.Exit();
        }

        private void dayOneButton_Click(object sender, EventArgs e)
        {
            //If the day one button is pressed, the spot in the list is set to 1 and the forecast form opens
            numFore = 1;
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
        }

        private void dayTwoButton_Click(object sender, EventArgs e)
        {
            //If the day two button is pressed, the spot in the list is set to 2 and the forecast form opens
            numFore = 2;
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
        }

        private void dayThreeButton_Click(object sender, EventArgs e)
        {
            //If the day three button is pressed, the spot in the list is set to 3 and the forecast form opens
            numFore = 3;
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
        }

        private void dayFourButton_Click(object sender, EventArgs e)
        {
            //If the day four button is pressed, the spot in the list is set to 4 and the forecast form opens
            numFore = 4;
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //if the main menu button is pressed, the mainmenu form opens
            MainMenu mm = new MainMenu();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
            mm.BringToFront();
        }

        private void ForecastMenu_Load(object sender, EventArgs e)
        {
            //is used to convert the month int value to the month name
            System.Globalization.DateTimeFormatInfo mfi = new
            System.Globalization.DateTimeFormatInfo();

            //Displays the correct month and day to the buttons
            dayOneButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast1[1])) + " "+ forecast1[2];
            dayTwoButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast2[1])) + " " + forecast2[2];
            dayThreeButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast3[1])) + " " + forecast3[2];
            dayFourButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast4[1])) + " " + forecast4[2];
        }
    }
}
