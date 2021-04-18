using System;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class LuckyNumberResults : Form
    {
        public int myLuckyNumber = 0;

        public LuckyNumberResults()
        {
            InitializeComponent();
        }


        // set luckyNumberLabel to the value passed in by the other form
        public void setLuckyNumberText(int number)
        {
            luckyNumberLabel.Text = number.ToString();
        }

        // hide form 2 vice destroying it everytime the second form in exited
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
