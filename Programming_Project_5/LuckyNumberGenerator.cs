using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class LuckNumberGenerator : Form
    {
        LuckyNumberResults resultsForm = new LuckyNumberResults();

        List<int> invalids;

        private readonly int HEIGHT_INDEX = 0;
        private readonly int AGE_INDEX = 1;
        private readonly int SIBLING_INDEX = 2;


        public LuckNumberGenerator()
        {
            InitializeComponent();
            // set default value of the drop down menu to prevent null reference exceptions
            coinFlipChoice.SelectedIndex = 0;
            invalids = new List<int>();
        }

        // calculate your lucky number.  This is not random. Results should be the same give the same input
        private void luckyNumberButton_Click(object sender, EventArgs e)
        {
            // Reset error text color, if changed due to incorrect input by the user
            resetTextColor();

            // check to ensure all values entered by the user can be parsed to int
            if (validateInput())
            {
                // set the lucky number on the other form to the result of the lucky number calculation
                resultsForm.myLuckyNumber = generateLuckyNumber();
                // set the lucky number text on the other form 
                resultsForm.setLuckyNumberText(resultsForm.myLuckyNumber);
                // show the results form
                resultsForm.Show();
                return;
            }

            // locate all invalid fields, add them to a list
            findInvalidInput();

            //change invalid fields text color to red
            updateInvalid();

        }

        // reset text color to black
        private void resetTextColor()
        {
            ageTextBox.ForeColor = Color.Black;
            heightTextBox.ForeColor = Color.Black;
            siblingsTextBox.ForeColor = Color.Black;
        }

        // updated invalid fields text color to red
        private void updateInvalid()
        {
            foreach(int number in invalids)
            {
                switch (number)
                {
                    
                    case 0:

                        heightTextBox.ForeColor = Color.Red;

                        break;

                    case 1:

                        ageTextBox.ForeColor = Color.Red;

                        break;

                    case 2:

                        siblingsTextBox.ForeColor = Color.Red;

                        break;

                    default:

                        break;
                }
            }
            
        }

        // find the invalid fields and add them to the invalids list
        private void findInvalidInput()
        {
            // empty invalids to avoid duplicates
            invalids.Clear();

            // if height field is not valid
            if (!validateHeight())
            { 
                // add it to the list
                invalids.Add(HEIGHT_INDEX);
            }

            // if age field is invalid
            if (!validateAge())
            {
                // add it to the list
                invalids.Add(AGE_INDEX);
            }
            
            // if siblings field is invalid
            if (!validateSiblings())
            {
                // add it to the list
                invalids.Add(SIBLING_INDEX);
            }

        }

        // check to see if inputs are valid
        private bool validateInput()
        {
            // all checks passed return true (Valid entry)
            if (validateAge() && validateHeight() && validateSiblings()) return true;

            // one of the three checks did not pass.  Return false (Invalid entry)
            return false;
        }

        // check to see if height field is valid
        private bool validateHeight()
        {
            // if the string value input for height is parsable to int return true
            if (int.TryParse(heightTextBox.Text, out _)) return true;

            // not parsable.  Return false
            return false;
        }

        // check if age field is valid
        private bool validateAge()
        {
            // if age can be parsed to int, return true
            if (int.TryParse(ageTextBox.Text, out _)) return true;

            // if not return false
            return false;
        }

        // is siblings field is valid?
        private bool validateSiblings()
        {
            // if sibling unput can be parsed to an int return true
            if (int.TryParse(siblingsTextBox.Text, out _)) return true;

            // if not, return false
            return false;
        }

        // random mathematic conversion to scramble results. Many unrealistic inputs will result in the lucky number being zero.  
        // mostly because I am mean and wish to deny gratification to those who would seek to do such evil to my poor little app. 
        private int generateLuckyNumber()
        {
            // placeholders
            int heightValue = 0;
            int ageValue = 0;
            int siblingsValue = 0;
            int luckyNumber = 0;

            // if heads is selected
            if ("Heads".Equals(coinFlipChoice.Text))
            {
                // random math with little thought put into it. Only really tried to prevent cases that would result in / by zero
                heightValue = height() / 10;
                ageValue = convertAge(age());
                siblingsValue = siblings();

                // nonsensical math
                luckyNumber = heightValue * ageValue / (siblingsValue + 1);
                return luckyNumber;
            }

            // divide by 10 to keep number down most of the time
            heightValue = height() / 10;
            ageValue = convertAge(age());
            siblingsValue = siblings();

            // ...math...
            luckyNumber = ageValue * siblingsValue / (heightValue / 3);

            return luckyNumber;
        }

        // convert age to a number 10 or less.  The idea being we would go to the next 10th position and subtract the age
        private int convertAge(int age)
        {
            // 10th position ++; example 33
            int nextFirstDigit = age;
            // shift decimal 1 position left; example 3
            int temp = age / 10;
            // example 4
            temp++;
            // move decimal back to the right; example 40
            temp = temp * 10;
            // example result: 7
            temp = temp - age;

            return temp;
        }

        // return parsed string as an int or default to 1 to limit * 0 and prevent / 0
        private int height()
        {
            int height;

            if(int.TryParse(heightTextBox.Text, out height))
            {
                return height;
            }

            return 1;
        }

        // return parsed string as an int or default to 1 to limit * 0 and prevent / 0
        private int age()
        {
            int age;

            if (int.TryParse(ageTextBox.Text, out age))
            {
                return age;
            }

            return 1;
        }

        // return parsed string as an int or default to 1 to limit * 0 and prevent / 0
        private int siblings()
        {
            int siblings;

            if (int.TryParse(siblingsTextBox.Text, out siblings))
            {
                return siblings;
            }

            return 1;
        }

    }
}
