using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPU_Inventory
{
    public class LoginLogic
    {
        // array to hold the code
        private char[] code;
        // array to hold the code attempt
        private char[] codeAttempt;
        // set the max code length to match UI restrictions
        private readonly int CODEMAXDIGITS = 4;
        private int digitsEntered;

        public LoginLogic()
        {
            // set default code to all 5s 
            setDefaultCode(CODEMAXDIGITS);
            // set default attempt to '_'
            setDefaultCodeAttempt(CODEMAXDIGITS);
            // initialize digits entered to 0
            digitsEntered = 0;
        }

        // set code default value
        private void setDefaultCode(int maxDigits)
        {
            // create an array of user given length
            code = new char[maxDigits];

            // set the value of each index to '5'
            for (int i = 0; i < maxDigits; i++)
            {
                code.SetValue('5', i);
            }
        }

        // set default value of code attempt to all '_'
        private void setDefaultCodeAttempt(int maxDigits)
        {
            // create array of user given length 
            codeAttempt = new char[maxDigits];

            // set the value of each index to '_'
            for (int i = 0; i < maxDigits; i++)
            {
                codeAttempt.SetValue('_', i);
            }
        }

        // cheeck if the user has entered enough digits
        public bool codeIsFull()
        {
            // if digits entered is less the the code length
            if (digitsEntered < CODEMAXDIGITS)
            {
                return false;
            }

            return true;
        }

        // insert number clicked into the code attempt array
        public void insertNumber(char number)
        {
            // set the value of the number clicked to the next index in the code attempt array
            codeAttempt.SetValue(number, digitsEntered);
            digitsEntered++;
        }

        // check to see if the code attempt matches the actual code
        public bool checkCode()
        {
            int index = 0;

            // check each index and return false if any index does not match
            foreach (char number in code)
            {
                if (!compareCodeIndexValues(index)) return false;
                index++;
            }
            // return true if all indexes match
            return true;
        }

        // check the value of the same index in code and code attempt
        private bool compareCodeIndexValues(int index)
        {
            bool codeMatch = code[index].Equals(codeAttempt[index]);

            // return true if this index matches, else return false
            return codeMatch;
        }

        // is code correct?
        public bool isCodeCorrect()
        {
            // only check if user entered enough digits
            if (codeIsFull())
            {
                if (checkCode()){
                    // return true if the code attempt matches the code
                    return true;
                }
                // if code does not match, return false
                return false;
            }

            // if user did not enter enough digits, return false
            return false;
        }

        // return the value of digits the user has entered. minus one to account for digit incremented within insertNumber()
        public int getDigitsEntered()
        {
            return this.digitsEntered - 1;
        }

        // reset digits entered to zero. Allows user to try again if incorrect digits entered
        public void resetDigitsEntered()
        {
            this.digitsEntered = 0;
        }
    }
}
