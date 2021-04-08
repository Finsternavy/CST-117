using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

// Author: Christopher Finster
// CST-117, Grand Canyon University
// Written 7 Apr 2021.  Last update: 7 Apr 2021

// Note: See README.txt for explanation of deviations from instructions.

namespace Programming_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Place all labels in a List for iteration later
            initializeBoardSpaceLabels();

            // initialize random number variable
            randomXO = new Random();

            // set default available board spaces
            resetAvailableBoardSpaces();
        }

        // Declare the board spaces 2D array
        int[,] boardSpaces;

        // This list holds all the labels for iteration later
        List<Label> boardSpaceLabels = new List<Label>();

        // This list hold available board space to ensure the random index has not already been claimed
        List<int> availableBoardSpaces = new List<int>();

        // used in initiateAvailableBoardSpaces() to ensure proper board spaces are reset between games
        int assignedBoardSpaces = 0;
        int maxAvailableBoardSpaces = 9;

        // Static to ensure results are not duplicated
        static Random randomXO;

        // x index of the 2D array
        int xIndex = 0;
        // y index of the 2D array
        int yIndex = 0;
        // value of xIndex and yIndex converted to array value
        int convertedXY = 0;

        // max x index
        const int maxXIndex = 2;
        // max y index
        const int maxYIndex = 2;

        // track players turn. 0 = X's turn, 1 = O's turn
        int playersTurn = 0;

        // track number of iterations to sync boardSpace array with the boardSpaceLabel List updates
        int iterations = 0;

        // hold necessary string to set winnerTextBoxText at the end of a game
        string winnerString = "It's a draw!";
        // used to check if a winner has been declared
        bool winner = false;

        // used to print contents of available board spaces for debugging purposes
        StringBuilder sb = new StringBuilder();

        // used in wait() the delay between turn so user can see the action unfold
        Stopwatch stopWatch = new Stopwatch();

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // default winnerString to draw
            winnerString = "It's a draw!";

            // default winner textbox text to blank
            winnerTextBox.Text = "";

            // default winner to false
            winner = false;

            // Easily identify separate logs between multiple "New Game" button presses in console. Logs for debugging purposes
            Console.WriteLine("--------------New Game Started---------------");

            // reset available board spaces to reflect all potential indexes ( 0 - 8 )
            resetAvailableBoardSpaces();

            // set all label text to ""
            resetBoardSpaceLabels();

            // reset board space array values
            resetBoardSpaceArray();

            // start the game by executing first players turn 
            runTicTacToeSimulation();

        }

        public void resetAvailableBoardSpaces()
        {
            // if spaces are available from previous game 
            if (availableBoardSpaces.Count > 0)
            {
                // remove them
                availableBoardSpaces.Clear();
            }

            // reset assignedBoardSpaces counter to restart at 0
            assignedBoardSpaces = 0;

            // while all board spaces are not made available
            while (assignedBoardSpaces < maxAvailableBoardSpaces)
            {
                // add the current value of assignedBoardSpaces to the available board spaces list. This is used to check the converted index
                availableBoardSpaces.Add(assignedBoardSpaces);
                // increment assignedBoardSpaces
                assignedBoardSpaces++;
            }
        }

        // reset all board space labels to show unused board spaces in next game
        private void resetBoardSpaceLabels()
        {
            // for each label in the list, set the text to blank
            foreach (Label spaceLabel in boardSpaceLabels)
            {
                spaceLabel.Text = "";
            }
        }

        // set default values in the array
        private void resetBoardSpaceArray()
        {
            // all values defaulted to '3' to avoid erroneouse winner declaration
            boardSpaces = new int[maxYIndex + 1, maxXIndex + 1] { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };
        }

        // run simulation method
        private void runTicTacToeSimulation()
        {
            // Displayer current players turn in console for debugging purposes
            Console.WriteLine("It is " + getPlayersTurn() + " turn");

            // if no winner delcared and there are available board spaces
            if (winner.Equals(false) && availableBoardSpaces.Count > 0)
            {
                executeTurn();

                if (checkForWinner())
                {
                    // Print to console that the game has ended for debugging purposes only
                    Console.WriteLine("----------End of Game----------");
                    // skip the else statement
                    return;
                }
                else
                {
                    // redraw the display to reflect players turn
                    Update();

                    // delay to allow user to see whats going on
                    Wait(500);

                    // switches current player and starts their turn
                    endTurn();
                }
            }
            else
            {
                // Print to console that the current player has won the game
                Console.WriteLine(winnerString);
            }

            // if no winner was declared set the winner textBox text to reflect a draw
            if (winner.Equals(false))
            {
                winnerTextBox.Text = "It's a draw!";
            }

        }

        // execute the current players turn
        private void executeTurn()
        {
            // roll random indexes
            setXYIndexes();

            // is the converted index still available?
            if (checkIfSpaceAvailable(convertedXY))
            {
                // set values of this board space and udpate the the associated label text and remove this index from the available board 
                // board spaces array
                updateGameData();
            }
            else
            {
                // Print to console the index is not available and player is re-rolling indexes
                Console.WriteLine("That index is not available. Re-rolling...");

                // the index rolled by the player was not available. Restart turn.
                executeTurn();
            }
        }

        // switch players
        private void endTurn()
        {
            changePlayersTurn();

            // Simulate current players turn
            runTicTacToeSimulation();
        }

        public void setXYIndexes()
        {
            // set y and x indexes to a random number between 0 and 3 non-inclusive
            yIndex = randomXO.Next(maxYIndex + 1);
            xIndex = randomXO.Next(maxXIndex + 1);

            // print x and y indexes to console for debugging purposes
            Console.WriteLine("x = " + xIndex + "  y = " + yIndex);

            // convert x and y to a linear index
            convertXYtoItration(yIndex, xIndex);

            // print conversion to console for debugging purposes
            Console.WriteLine("converted x y: " + convertedXY.ToString()); ;
        }

        // switch between players after each turn
        private void changePlayersTurn()
        {
            // if its O's turn
            if (playersTurn.Equals(0))
            {
                // set players turn to X (X = 1, O = 0)
                playersTurn = 1;
                return;
            }
            // set players turn to O
            playersTurn = 0;
        }

        // make sure availableBoardSpaces list contains all board spaces
       

        // is the converted index still available?
        public bool checkIfSpaceAvailable(int convertedXY)
        {
            // check all remaining available board spaces. 
            for(int i = 0; i < availableBoardSpaces.Count; i++)
            {
                // if the converted index is still available
                if (availableBoardSpaces[i].Equals(convertedXY))
                {
                    // let the program know the converted index is still available
                    return true;
                }
            }
            // let the program know the converted index is not available and a new index will need to be determined
            return false;
        }

        // test to verify label and board space updates were properly synced. For debugging purposes only. 
        private void testArrayOrder()
        {
            foreach(int space in boardSpaces)
            {
                // set the values in boardSpaces array
                boardSpaces.SetValue(iterations, this.yIndex, this.xIndex);
                // set the labels based on the current boardSpace array index. Should match add order in initializeBoardSpaceLabels()
                boardSpaceLabels[iterations].Text = boardSpaces[yIndex, xIndex].ToString();
                // cycle through the 2D array left to right, top to bottom.
                adjustIndex();
            }
        }

        // Return the current players turn
        public string getPlayersTurn()
        {
            // if its O's turn
            if (playersTurn.Equals(0))
            {
                return "O's";
            }
            // if its X's turn
            return "X's";
        }

        // set values of this board space and udpate the the associated label text and remove this index from the available board 
        // board spaces array
        private void updateGameData()
        {
            // Print out all available spaces to console for debugging purposes
            Console.WriteLine(printAvailableSpaces());
            // Print current player and the index of the board space they are taking to console for debugging purposes
            Console.WriteLine(getPlayersTurn() + " claims index (" + xIndex.ToString() + ", " + yIndex.ToString() + ")");
            // Print the converted index to console to console to compare with next printout of available spaces to ensure correct
            // index was claimed for debugging purposes
            Console.WriteLine(convertedXY + " was removed.");

            // Remove the converted index from available spaces list
            availableBoardSpaces.Remove(convertedXY);

            //set the value of the board space claimed to the value of the current players turn
            boardSpaces.SetValue(playersTurn, yIndex, xIndex);

            // marks the board space displaying the player that claimed the space
            setBoardSpaceText();
        }

        // set the text box of the selected index to reflect the current player
        public void setBoardSpaceText()
        {
            // if the current index was claimed by player "O"
            if(boardSpaces.GetValue(yIndex, xIndex).Equals(0)){

                // Set the associated label text to "O"
                boardSpaceLabels[convertedXY].Text = "O";
                return;
            }

            // If the current index is claimed by player "X", set to "X"
            boardSpaceLabels[convertedXY].Text = "X";
        }

        // convert (x, y) index to linear index
        public void convertXYtoItration(int yIndex, int xIndex)
        {
            /*     Picture a 2D array that is 3x3 and the x, y index is (1, 1)
             *     
             *     ( x , y )          ( linear equivelant )
             *     
             *       0  1  2                0  1  2
             *    0 [ ][ ][ ]            0 [0][1][2]
             *    1 [ ][x][ ]            1 [3][4][5]
             *    2 [ ][ ][ ]            2 [6][7][8]
             *    
             *   (3) =  (1)   *       (3)
             *    y  = yIndex * number of columns (maxXIndex + 1 to account for index starting at 0)
             *    In this example the y conversion = 3
             *    
             *   (1) =  (1)    
             *    x  = itself
             *    
             *          (4)    = (1) + (3)         
             *    linear Index =  x  +  y
             *    
            */

            // set convertedXY to the linear equivalent of (x, y)
            convertedXY = (yIndex * (maxXIndex + 1)) + xIndex;
        }

        // add board space labels to the list for iteration later
        private void initializeBoardSpaceLabels()
        {
            boardSpaceLabels.Add(spaceTopLeft);
            boardSpaceLabels.Add(spaceTopMid);
            boardSpaceLabels.Add(spaceTopRight);
            boardSpaceLabels.Add(spaceMidLeft);
            boardSpaceLabels.Add(spaceMidMid);
            boardSpaceLabels.Add(spaceMidRight);
            boardSpaceLabels.Add(spaceBottomLeft);
            boardSpaceLabels.Add(spaceBottomMid);
            boardSpaceLabels.Add(spaceBottomRight);
        }

        // used for debugging only with the testArray() debugging method
        private void adjustIndex()
        {
            // count total iterations for syncing label index with array iterations
            iterations++;

            // increment the x index of the array
            xIndex++;

            // if the new xIndex is now out of bounds
            if(xIndex > maxXIndex)
            {
                // increase y if last column in the row has been reached
                yIndex++;
                // reset x to first column in the row
                xIndex = 0;
            }
            // if the current yIndex is out of bounds
            if(yIndex > maxYIndex)
            {
                // reset all indexes
                yIndex = 0;
                xIndex = 0;
                iterations = 0;
            }
        }

        private bool checkForWinner()
        {
            // if all index in any row, column, or diagonal are occupied by O's
            if (boardSpaces[0, 0].Equals(0) & boardSpaces[0, 1].Equals(0) & boardSpaces[0, 2].Equals(0) ||
                boardSpaces[1, 0].Equals(0) & boardSpaces[1, 1].Equals(0) & boardSpaces[1, 2].Equals(0) ||
                boardSpaces[2, 0].Equals(0) & boardSpaces[2, 1].Equals(0) & boardSpaces[2, 2].Equals(0) ||
                boardSpaces[0, 0].Equals(0) & boardSpaces[1, 0].Equals(0) & boardSpaces[2, 0].Equals(0) ||
                boardSpaces[0, 1].Equals(0) & boardSpaces[1, 1].Equals(0) & boardSpaces[2, 1].Equals(0) ||
                boardSpaces[0, 2].Equals(0) & boardSpaces[1, 2].Equals(0) & boardSpaces[2, 2].Equals(0) ||
                boardSpaces[0, 0].Equals(0) & boardSpaces[1, 1].Equals(0) & boardSpaces[2, 2].Equals(0) ||
                boardSpaces[0, 2].Equals(0) & boardSpaces[1, 1].Equals(0) & boardSpaces[2, 0].Equals(0))
            {
                // set winner textBox text to reflect O's win
                winnerTextBox.Text = "O is the winner!";
                winnerString = "O is the winner!";
                winner = true;
                // end method execution
                return true;
            }
            // if all index in any row, column, or diagonal are occupied by X's
            if (boardSpaces[0, 0].Equals(1) & boardSpaces[0, 1].Equals(1) & boardSpaces[0, 2].Equals(1) ||
                boardSpaces[1, 0].Equals(1) & boardSpaces[1, 1].Equals(1) & boardSpaces[1, 2].Equals(1) ||
                boardSpaces[2, 0].Equals(1) & boardSpaces[2, 1].Equals(1) & boardSpaces[2, 2].Equals(1) ||
                boardSpaces[0, 0].Equals(1) & boardSpaces[1, 0].Equals(1) & boardSpaces[2, 0].Equals(1) ||
                boardSpaces[0, 1].Equals(1) & boardSpaces[1, 1].Equals(1) & boardSpaces[2, 1].Equals(1) ||
                boardSpaces[0, 2].Equals(1) & boardSpaces[1, 2].Equals(1) & boardSpaces[2, 2].Equals(1) ||
                boardSpaces[0, 0].Equals(1) & boardSpaces[1, 1].Equals(1) & boardSpaces[2, 2].Equals(1) ||
                boardSpaces[0, 2].Equals(1) & boardSpaces[1, 1].Equals(1) & boardSpaces[2, 0].Equals(1))
            {
                // set winner textbox text to reflect X's win
                winnerTextBox.Text = "X is the winner!";
                winnerString = "X is the winner!";
                winner = true;

                // end method execution
                return true;
            }

            
            return false;
        }

        // for debugging purposes only. prints the contents of the available spaces list
        private string printAvailableSpaces()
        {
            sb.Clear();
            sb.Append("Spaces available: ");
            foreach(int space in availableBoardSpaces)
            {
                sb.Append(space.ToString() + ", ");
            }

            return sb.ToString();
        }

        // method to delay next call so user can see the update
        public void Wait(int time)
        {
            // Restart stopwatch
            stopWatch.Restart();

            // has the wait time been reached?
            bool enoughTimePassed = false;

            // if wait time has not been reached
            while (!enoughTimePassed)
            {
                // holds elapsed time
                TimeSpan timePassed = stopWatch.Elapsed;

                // if elapsed time surpasses wait time
                if (timePassed.TotalMilliseconds > time)
                {
                    enoughTimePassed = true;
                    stopWatch.Stop();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
