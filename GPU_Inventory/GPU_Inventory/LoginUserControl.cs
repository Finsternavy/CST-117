using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPU_Inventory
{
    public partial class LoginUserControl : UserControl
    {
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
        private readonly int MAXLABELARRAYSIZE = 4;
        private LoginLogic loginLogic = new LoginLogic(4);
        Label[] digitLabels;

        public LoginUserControl()
        {
            InitializeComponent();
            digitLabels = new Label[MAXLABELARRAYSIZE];
            initializeDigitLabelArray();
        }

        private void initializeDigitLabelArray()
        {
            digitLabels.SetValue(digit1Label, 0);
            digitLabels.SetValue(digit2Label, 1);
            digitLabels.SetValue(digit3Label, 2);
            digitLabels.SetValue(digit4Label, 3);


            for (int i = 0; i < digitLabels.Length; i++)
            {
                digitLabels[i].Text = "_";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(ONE);
                digitLabels[loginLogic.getDigitsEntered()].Text = ONE.ToString();
                checkCode();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(TWO);
                digitLabels[loginLogic.getDigitsEntered()].Text = TWO.ToString();
                checkCode();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(THREE);
                digitLabels[loginLogic.getDigitsEntered()].Text = THREE.ToString();
                checkCode();
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(FOUR);
                digitLabels[loginLogic.getDigitsEntered()].Text = FOUR.ToString();
                checkCode();
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(FIVE);
                digitLabels[loginLogic.getDigitsEntered()].Text = FIVE.ToString();
                checkCode();
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(SIX);
                digitLabels[loginLogic.getDigitsEntered()].Text = SIX.ToString();
                checkCode();
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(SEVEN);
                digitLabels[loginLogic.getDigitsEntered()].Text = SEVEN.ToString();
                checkCode();
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(EIGHT);
                digitLabels[loginLogic.getDigitsEntered()].Text = EIGHT.ToString();
                checkCode();
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(NINE);
                digitLabels[loginLogic.getDigitsEntered()].Text = NINE.ToString();
                checkCode();
                return;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!loginLogic.codeIsFull())
            {
                loginLogic.insertNumber(ZERO);
                digitLabels[loginLogic.getDigitsEntered()].Text = ZERO.ToString();
                checkCode();
                return;
            }
        }

        private void checkCode()
        {
            if (loginLogic.isCodeCorrect())
            {
                this.Hide();
            }
        }

        private void asteriskButton_Click(object sender, EventArgs e)
        {
            if (loginLogic.checkCode())
            {
                this.Hide();
                return;
            }

            resetAttempt();
        }

        private void poundButton_Click(object sender, EventArgs e)
        {
            resetAttempt();
        }

        private void resetAttempt()
        {
            loginLogic.resetDigitsEntered();
            initializeDigitLabelArray();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poundButton_Click_1(object sender, EventArgs e)
        {
            resetAttempt();
        }
    }
}

