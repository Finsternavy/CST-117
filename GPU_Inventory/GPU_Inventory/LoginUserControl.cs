using System;
using System.Windows.Forms;

// Author: Christopher Finster
// CST-117 Milestone 4 and 5.  Inventory Manager
// Last updated: 14 Apr 2021

namespace GPU_Inventory
{
    public partial class LoginUserControl : UserControl
    {   // hold char representation of numbers in readonly state. Passed to loginLogic for use in code attempt (ONE - ZERO)
        private readonly char ONE = '1';
        private readonly char TWO = '2';
        private readonly char THREE = '3';
        private readonly char FOUR = '4';
        private readonly char FIVE = '5';
        private readonly char SIX = '6';
        private readonly char SEVEN = '7';
        private readonly char EIGHT = '8';
        private readonly char NINE = '9';
        private readonly char ZERO = '0';
        private readonly int INDEX_ZERO = 0;
        private readonly int INDEX_ONE = 1;
        private readonly int INDEX_TWO = 2;
        private readonly int INDEX_THREE = 3;
        // Default maxlabel array size to 4 to match UI design
        private readonly int MAXLABELARRAYSIZE = 4;
        // instance of logic associated with this user control. Separation of visual and model controls
        private LoginLogic loginLogic = new LoginLogic();
        // holds digit labels for assignment in sync with user interaction
        Label[] digitLabels;

        public LoginUserControl()
        {
            InitializeComponent();
            digitLabels = new Label[MAXLABELARRAYSIZE];
            initializeDigitLabelArray();
        }

        // Assign values of digitLabels array to the correct digit labels and set their default text to '_'
        private void initializeDigitLabelArray()
        {
            digitLabels.SetValue(digit1Label, INDEX_ZERO);
            digitLabels.SetValue(digit2Label, INDEX_ONE);
            digitLabels.SetValue(digit3Label, INDEX_TWO);
            digitLabels.SetValue(digit4Label, INDEX_THREE);

            for (int i = 0; i < digitLabels.Length; i++)
            {
                digitLabels[i].Text = "_";
            }
        }

        // executs if user click number 1
        private void button1_Click(object sender, EventArgs e)
        {
            // if the code is not full
            if (!loginLogic.codeIsFull())
            {
                // insert this number into the code attempt array
                loginLogic.insertNumber(ONE);
                // set the digit label to this number based on # of digits the user has entered.
                digitLabels[loginLogic.getDigitsEntered()].Text = ONE.ToString();
                // auto-check if user has entered the correct code
                checkCode();
            }
        }

        // Same logic as button1_Click.  Pattern continues for buttons 1 - 9 and 0; Will not comment those methods
        private void button2_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(TWO);
                digitLabels[loginLogic.getDigitsEntered()].Text = TWO.ToString();
                checkCode();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(THREE);
                digitLabels[loginLogic.getDigitsEntered()].Text = THREE.ToString();
                checkCode();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(FOUR);
                digitLabels[loginLogic.getDigitsEntered()].Text = FOUR.ToString();
                checkCode();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(FIVE);
                digitLabels[loginLogic.getDigitsEntered()].Text = FIVE.ToString();
                checkCode();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(SIX);
                digitLabels[loginLogic.getDigitsEntered()].Text = SIX.ToString();
                checkCode();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(SEVEN);
                digitLabels[loginLogic.getDigitsEntered()].Text = SEVEN.ToString();
                checkCode();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(EIGHT);
                digitLabels[loginLogic.getDigitsEntered()].Text = EIGHT.ToString();
                checkCode();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(NINE);
                digitLabels[loginLogic.getDigitsEntered()].Text = NINE.ToString();
                checkCode();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(ZERO);
                digitLabels[loginLogic.getDigitsEntered()].Text = ZERO.ToString();
                checkCode();
            }
        }

        // reset code attempt. User to clear errors if user clicks the wrong button.  Allows them to start again
        private void poundButton_Click_1(object sender, EventArgs e)
        {
            resetAttempt();
        }

        // manual code check.  Resets attempt if code is wrong. Program currently set to autoCheck on last digit
        // This button will only clear incorrect attempts currently.  Leaving code for flexibility
        private void asteriskButton_Click(object sender, EventArgs e)
        {
            if (loginLogic.checkCode())
            {
                this.Hide();
                return;
            }

            resetAttempt();
        }

        // if user entered the correct code, hide the lock screen
        private void checkCode()
        {
            if (loginLogic.isCodeCorrect())
            {
                this.Hide();
            }
        }

        // clear digits entered count and resets digit labels
        private void resetAttempt()
        {
            loginLogic.resetDigitsEntered();
            initializeDigitLabelArray();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

