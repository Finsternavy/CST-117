using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // hold the current values for calculating total calories in updateTotalCalories()
        int currentCaloriesFromFatInt;
        double currentCaloriesFromFatDouble;
        int currentCaloriesFromCarbsInt;
        double currentCaloriesFromCarbsDouble;

        // Manage input type to convert to appropriate type when finding the total calories
        bool fatWasInt = false;
        bool carbsWasInt = false;
        

        private void convertButton_Click(object sender, EventArgs e)
        {
            updateFatConversion();
            updateCarbsConversion();
            updateTotalCalories();
            resetDefaultValues();
        }

        public void updateFatConversion()
        {
            // Reset textbox color if previously entered incorrect data type
            fatGramsTextBox.BackColor = Color.White;

            int gramsInt;
            double gramsDouble;

            if (int.TryParse(fatGramsTextBox.Text, out gramsInt))
            {
                // set state of dataype user entered for fat grams so updateTotalCalories will know how to process the data
                fatWasInt = true;

                // update current calories for finding total in updateTotalCalories() 
                currentCaloriesFromFatInt = Calories.fatCalories(gramsInt);

                // Set results for fat grams result label
                caloriesFromFatResultsLabel.Text = currentCaloriesFromFatInt.ToString();

                // skip rest of code in this method
                return;
            }
            if (double.TryParse(fatGramsTextBox.Text, out gramsDouble))
            {
                // set state of datatype user entered so the updateTotalCalories() will know it was a double
                fatWasInt = false;

                // set current calories for finding total later
                currentCaloriesFromFatDouble = Calories.fatCalories(gramsDouble);

                // set results label appropriately 
                caloriesFromFatResultsLabel.Text = currentCaloriesFromFatDouble.ToString();

                return;
            }

            // if user did not enter an int or double value...
            caloriesFromFatResultsLabel.Text = "0";
            fatGramsTextBox.BackColor = Color.Red;
            fatGramsTextBox.Text = "Numbers Only!";
        }

        public void updateCarbsConversion()
        {
            // updateCarbsConversion() follows the same logic as updateFatConversion(). Read above for explanation of each line

            carbsGramsTextBox.BackColor = Color.White;

            int gramsInt;
            double gramsDouble;

            if (int.TryParse(carbsGramsTextBox.Text, out gramsInt))
            {
                carbsWasInt = true;
                currentCaloriesFromCarbsInt = Calories.carbCalories(gramsInt);
                caloriesFromCarbsResultsLabel.Text = currentCaloriesFromCarbsInt.ToString();

                return;
            }
            if (double.TryParse(carbsGramsTextBox.Text, out gramsDouble))
            {
                carbsWasInt = false;
                currentCaloriesFromCarbsDouble = Calories.fatCalories(gramsDouble);
                caloriesFromCarbsResultsLabel.Text = currentCaloriesFromCarbsDouble.ToString();

                return;
            }

            caloriesFromCarbsResultsLabel.Text = "0";
            carbsGramsTextBox.BackColor = Color.Red;
            carbsGramsTextBox.Text = "Numbers Only!";
        }

        public void updateTotalCalories()
        {
            // Check state of datatypes user entered to handle the data appropriately 

            // fat input was int and so was carb input
            if(fatWasInt && carbsWasInt)
            {
                // calculate total
                int result = currentCaloriesFromFatInt + currentCaloriesFromCarbsInt;

                // update total results label
                totaCaloriesResultsLabel.Text = result.ToString();

                // skip rest of code in method
                return;
            }
            // fat input was a double and so was carb input
            if(!fatWasInt && !carbsWasInt)
            {
                // same logic as above if statement
                double result = currentCaloriesFromFatDouble + currentCaloriesFromCarbsDouble;
                totaCaloriesResultsLabel.Text = result.ToString();
                return;
            }
            // fat input was int and carb input was double
            if(fatWasInt && !carbsWasInt)
            {
                // convert int value to a double
                double fatToDouble = Convert.ToDouble(currentCaloriesFromFatInt);

                // calculate result
                double result = fatToDouble + currentCaloriesFromCarbsDouble;

                // update result label
                totaCaloriesResultsLabel.Text = result.ToString();

                // skip rest of code in method
                return;
            }
            // fat input was double and carb input was int
            if(!fatWasInt && carbsWasInt)
            {
                // same logic as above if statement

                double carbsToDouble = Convert.ToDouble(currentCaloriesFromCarbsInt);
                double result = currentCaloriesFromFatDouble + carbsToDouble;
                totaCaloriesResultsLabel.Text = result.ToString();
                return;
            }
        }

        public void resetDefaultValues()
        {
            // reset all current values to 0 to avoid potential errors in calculataion if multiple conversion are input by the user
            currentCaloriesFromFatInt = 0;
            currentCaloriesFromFatDouble = 0.00;
            currentCaloriesFromCarbsInt = 0;
            currentCaloriesFromCarbsDouble = 0.00;
        }

    }
}
