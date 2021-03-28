using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Exercise_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dice die1;
        Dice die2;

        int count = 0;

        // Used to delay the program so results of each roll can be displayed.
        Stopwatch stopWatch = new Stopwatch();

        private void rollButton_Click(object sender, EventArgs e)
        {
            // Reset count when button is pushed
            count = 0;

            // Used to pass sides 
            int sides;

            // Make sure the user entered a number
            if (int.TryParse(diceSideAssignmentTextbox.Text, out sides))
            {
                // Create two die of specified number of sides
                initializeDice(sides);

                //  Recursive method to roll the dice
                rollDice();

                // exit method.  Doing this allows me to avoid using else keyword 
                return;
            }


            // called only if user enters anything other than a number
            diceSideAssignmentTextbox.Text = "Invalid! Enter a number!";

        }

        // Creates two die with sides as specified by the user
        private void initializeDice(int sides)
        {
                die1 = new Dice(sides);
                die2 = new Dice(sides);
        }


        // Recursive method.  Rolls each dice and assigns value to corresponding label. Increment counter. Delay and redraw form. 
        public void rollDice()
        {
            die1.rollDie();
            // Assign value of the die roll to corresponding label
            die1Label.Text = die1.getRandomNumber().ToString();
            die2.rollDie();
            // Assign value of the die roll to corresponding label
            die2Label.Text = die2.getRandomNumber().ToString();

            count++;

            // check for snake eyes
            if (die1.getRandomNumber() == 1 && die2.getRandomNumber() == 1)
            {
                // show results
                MessageBox.Show("It took " + count + " rolls to get snake eyes!");

                // exit method
                return;

            }

            // redraw form
            Update();
            // allow user to see results before next roll
            Wait(500);

            // recursive call
            rollDice();
        }

        // method to delay next call so user can see the update
        public void Wait(int time)
        {
            stopWatch.Restart();
            bool enoughTimePassed = false;
            while (!enoughTimePassed)
            {
                TimeSpan timePassed = stopWatch.Elapsed;

                if (timePassed.TotalMilliseconds > time)
                {
                    enoughTimePassed = true;
                    stopWatch.Stop();
                }
            }
        }
    }
}
