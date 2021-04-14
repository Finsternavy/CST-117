using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPU_Inventory
{
    public class LoginLogic
    {
        private char[] code;
        private char[] codeAttempt;
        private readonly int CODEMAXDIGITS;
        private int digitsEntered;

        public LoginLogic(int maxDigits)
        {
            code = new char[4] { '5', '5', '5', '5' };
            codeAttempt = new char[4] { '_', '_', '_', '_' };
            CODEMAXDIGITS = maxDigits;
            digitsEntered = 0;
        }


        public bool codeIsFull()
        {
            if (digitsEntered < CODEMAXDIGITS)
            {
                return false;
            }

            return true;
        }

        public void insertNumber(char number)
        {
            codeAttempt.SetValue(number, digitsEntered);
            digitsEntered++;
        }

        public bool checkCode()
        {
            int index = 0;

            foreach (char number in code)
            {
                if (!compareCodeIndexValues(index)) return false;
                index++;
            }

            return true;
        }

        private bool compareCodeIndexValues(int index)
        {
            bool codeMatch = code[index].Equals(codeAttempt[index]);

            return codeMatch;
        }

        public bool isCodeCorrect()
        {
            if (codeIsFull())
            {
                if (checkCode()){
                    return true;
                }

                return false;
            }

            return false;
        }

        public int getDigitsEntered()
        {
            return this.digitsEntered - 1;
        }

        public void resetDigitsEntered()
        {
            this.digitsEntered = 0;
        }
    }
}
