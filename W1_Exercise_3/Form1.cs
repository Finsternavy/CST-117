using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1_Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click_1(object sender, EventArgs e)
        {
 
            if(inchesTextBox.Text != "")
            {

                //Convert text to a float and assign to inches
                float inches; ;

                if (float.TryParse(inchesTextBox.Text, out inches))
                {
                    inches = float.Parse(inchesTextBox.Text);
                    inchesErrorLabel.Text = "";
                    millimetersErrorLabel.Text = "";
                    inchesTextBox.BackColor = Color.White;
                    millimetersTextBox.BackColor = Color.White;
                    //formula to convert inches to millimeters
                    float millimeters = inches * 25.4f;
                    //Set the text value of millimetersTextBox text to the answer
                    millimetersTextBox.Text = millimeters.ToString("0.000");
                }
                else
                {
                    inchesTextBox.BackColor = Color.Red;
                    inchesErrorLabel.Text = "Please enter a number!";
                    
                }
                
            }else if (inchesTextBox.Text.Equals("") && millimetersTextBox.Text != "")
            {
                //Convert text to a float and assign to millimeters
                float millimeters; ;
                if (float.TryParse(millimetersTextBox.Text, out millimeters))
                {
                    millimeters = float.Parse(millimetersTextBox.Text);
                    millimetersErrorLabel.Text = "";
                    inchesErrorLabel.Text = "";
                    millimetersTextBox.BackColor = Color.White;
                    inchesTextBox.BackColor = Color.White;
                    //forumla to convert millimeters to inches
                    float inches = millimeters / 25.4f;
                    //Set the text of inchesTexbox text to the answer
                    inchesTextBox.Text = inches.ToString("0.000");
                }
                else
                {
                    millimetersTextBox.BackColor = Color.Red;
                    millimetersErrorLabel.Text = "Please enter a number!";
                }
                
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            millimetersTextBox.Text = "";
            inchesTextBox.Text = "";
            inchesTextBox.BackColor = Color.White;
            millimetersTextBox.BackColor = Color.White;
            inchesErrorLabel.Text = "";
            millimetersErrorLabel.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xButton(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
