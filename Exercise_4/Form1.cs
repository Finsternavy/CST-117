using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            secondsTextBox.ForeColor = Color.Black;
            //check to ensure user entered something
            if (secondsTextBox.Text != "")
            {
                int seconds;
                int result;

                //check to ensure what user entered is a number
                if(int.TryParse(secondsTextBox.Text, out seconds))
                {
                    //convert text to int
                    seconds = int.Parse(secondsTextBox.Text);

                    //if input is at least 1 minute but less than 1 hour
                    if(seconds >= 60 && seconds < 3600)
                    {
                        //utilize created static class for conversion method and assign to result value.
                        result = ConvertSeconds.convertToMinutes(seconds);

                        minutesLabel.Text = result.ToString("000");
                        hoursLabel.Text = "000";
                        daysLabel.Text = "000";
                    }
                    //if input is at least 1 hour but less than 1 day
                    else if (seconds >= 3600 && seconds < 86400)
                    {
                        result = ConvertSeconds.convertToHours(seconds);

                        minutesLabel.Text = "000";
                        hoursLabel.Text = result.ToString("000");
                        daysLabel.Text = "000";
                    }
                    //if input is at least 1 day
                    else if (seconds >= 86400)
                    {
                        result = ConvertSeconds.convertToDays(seconds);

                        minutesLabel.Text = "000";
                        hoursLabel.Text = "000";
                        daysLabel.Text = result.ToString("000");
                    }
                    else
                    {
                        //this should run if input is less than 1 minute
                        result = seconds;

                        minutesLabel.Text = result.ToString("000");
                        hoursLabel.Text = "000";
                        daysLabel.Text = "000";

                    }
                }
                else
                {
                    //if the user entered anything other than a number
                    Console.WriteLine("User entered invalid data type.  Please enter a number!");
                    secondsTextBox.ForeColor = Color.Red;
                    secondsTextBox.Text = "INVALID ENTRY!";
                }
            }
            else
            {
                //log to check that our if statement is functioning properly and verifying the user input  something
                Console.WriteLine("user did not input anything.");
            }
            
        }

        //Close the app with custom exit button since borders were removed. 
        private void xButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void complexConvertButton_Click(object sender, EventArgs e)
        {
            //reset input text color when user corrects input error
            secondsTextBox.ForeColor = Color.Black;

            if (secondsTextBox.Text != "")
            {
                int seconds;

                if(int.TryParse(secondsTextBox.Text, out seconds))
                {
                    seconds = int.Parse(secondsTextBox.Text);

                    //create the DHMTimeConversion object in order to pass values from ConvertSeconds static class method back to each label. 
                    var myCoversion = ConvertSeconds.convertToDayHourMinutes(seconds);

                    daysLabel.Text = myCoversion.getDays().ToString("000");
                    hoursLabel.Text = myCoversion.getHours().ToString("000");
                    minutesLabel.Text = myCoversion.getMinutes().ToString("000");
                }
                else
                {
                    //visual representation of an input error to the user
                    secondsTextBox.ForeColor = Color.Red;
                    secondsTextBox.Text = "INVALID ENTRY!";
                }

            }
        }
    }
}
