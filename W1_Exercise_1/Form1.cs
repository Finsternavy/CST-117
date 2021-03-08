using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1_Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //placeholders to pass to label
        string name = "";
        

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void generateMessageBtn_Click_1(object sender, EventArgs e)
        {
            //set name and favorite color according to user input
            name = nameTextBox.Text;
            //Set up message to pass to result label
            changeColor(colorDropDownBox.Text.ToString());
            string message = "Hello " + name + "! Your favorite color is " + colorDropDownBox.Text.ToString() + "!";
            //set result label text to message contents
            resultLabel.Text = message;
        }

        private void changeColor(string color)
        {
            switch (color)
            {
                case "Red":

                    BackColor = Color.Red;
                    ForeColor = Color.Black;

                    break;
                case "Black":

                    BackColor = Color.Black;
                    ForeColor = Color.White;

                    break;
                case "Blue":

                    BackColor = Color.Blue;
                    ForeColor = Color.Black;

                    break;
                case "Green":

                    BackColor = Color.Green;
                    ForeColor = Color.Black;

                    break;
                case "Yellow":

                    BackColor = Color.Yellow;
                    ForeColor = Color.Black;

                    break;
                case "Orange":

                    BackColor = Color.Orange;
                    ForeColor = Color.Black;

                    break;
                case "Pink":

                    BackColor = Color.Pink;
                    ForeColor = Color.Black;

                    break;
                case "White":

                    BackColor = Color.White;
                    ForeColor = Color.Black;

                    break;

                case "Brown":

                    BackColor = Color.SaddleBrown;
                    ForeColor = Color.Black;

                    break;

                default:

                    break;



            }
        }
    }
}
