using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            termsTextBox.BackColor = Color.White;

            // start at 3 for the lowest denominator in the sequence
            int denominater = 3;
            // start value at 4
            double pi = 4;
            // used to determine if the count is even or odd
            int counter = 1;

            // decided by user input
            int terms;


            // make sure the user entered a number
            if (int.TryParse(termsTextBox.Text, out terms))
            {
                while (counter < terms)
                {
                    //if counter is odd
                    if(counter % 2 != 0){

                        pi -= Convert.ToDouble(4) / denominater;
                        counter++;
                    }
                    // if counter is even
                    else
                    {
                        pi += Convert.ToDouble(4) / denominater;
                        counter++;
                    }
                    denominater += 2;
                }

                // set input text to display the number of terms used in the calculation 
                approximateInputLabel.Text = "Approximate value of pi after " + terms.ToString() + " terms";

                // display the answer
                piEqualsLabel.Text = "= " + pi.ToString();
            }
            else
            {
                termsTextBox.Text = "INVALID ENTRY!";
                termsTextBox.BackColor = Color.Red;
            }

        }
    }
}
