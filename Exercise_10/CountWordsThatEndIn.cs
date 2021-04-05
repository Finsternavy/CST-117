using System;

// Author: Christopher Finster
// CST-117, Exercise 10
// 5 Apr 2021
// Retrievable from: https://github.com/Finsternavy/CST-117/tree/main/Exercise_10

namespace Exercise_10
{
    static class CountWordsThatEndIn
    {
        // takes two char variables and a string
        public static int countWordsEndingIn(char char1, char char2, string textFileString)
        {
            // initialize the count at 0
            int count = 0;

            // set local char variables to simpify code
            char a = Char.ToLower(char1);
            char b = Char.ToLower(char2);

            // set file string to local string to simplify code
            string textFileToUpper = textFileString.ToLower();

            // separate string into a char array for easy iteration 
            char[] characterArray = textFileToUpper.ToCharArray();

            // used to set the index on Console.WriteLine in foreach loop for debugging purposes
            int indexFinder = 0;

            // print the array and display the index for debugging purposes
            foreach(char character in characterArray)
            {
                // write the char at the current index and its index in the array for debugging purposes
                Console.WriteLine(character + " index: " + indexFinder);
                indexFinder++;
            }

            // start i at 1 to avoid out of bounds when checking backward.
            // int i = is industry standard in for loops. I dont care if I lose points for this. Train how you fight
            for (int i = 1; i < characterArray.Length; i++)
            {
                // if the current index is not a letter and the previous letter is one you are looking for 
                if (!Char.IsLetter(characterArray[i]) && characterArray[i - 1].Equals(a) | characterArray[i - 1].Equals(b))
                {
                    // print the last letter to ensure it is one you are looking for, the current index to ensure it is not a letter, and 
                    // the return of !Char.IsLetter() to ensure it is false for debugging purposes
                    Console.WriteLine(characterArray[i - 1] + " at index " + (i - 1) + " is followed by " + characterArray[i] + " " +
                        Char.IsLetter(characterArray[i]));

                    // Increment count as a word ending in a target letter was found
                    count++;
                }
            }

            // return the number of words ending in one of the target letters
            return count;
        }
    }
}
