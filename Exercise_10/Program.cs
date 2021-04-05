using System;

// Author: Christopher Finster
// CST-117, Exercise 10
// 5 Apr 2021

namespace Exercise_10
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            // Used two char variables for ease of testing different characters
            char char1 = 'e';
            char char2 = 't';

            // read in test file... change file directory between "" to change the input file.  Must be a txt file. 
            string myFile = System.IO.File.ReadAllText(@"C:\Users\Finst\Documents\GitHub\CST-117\Exercise_10\TestFile.txt");

            // set count equal to the return value of the static countWordsEndingIn() method accepts 2 char variables and the file string
            int count = CountWordsThatEndIn.countWordsEndingIn(char1, char2, myFile);

            // Print out the final count
            Console.WriteLine("\r\nThere are " + count + " words that end in 'e' or 't'.");
        }
    }
}
