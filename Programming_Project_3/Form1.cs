using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Programming_Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                string text = System.IO.File.ReadAllText(ofd.FileName);
                originalTextBox.Text = text;

                // separate each word when there is a space of line break
                string[] words = text.Split(' ', '\n');

                // convert each word to lowercase
                convertEachToLowerCase(words);

                // sort the array alphabetically
                Array.Sort(words);

                string firstWord = words.First();
                string lastWord = words.Last();

                //MessageBox.Show("The first word is: " + firstWord + "\nThe last word is: " + lastWord);

                // holds result of longest word
                string longestWord = findLongestWord(words);

                //MessageBox.Show("The longest word is: " + longestWord);

                string wordWithMostVowels = findWordWithMostVowels(words);

                StringBuilder sb = new StringBuilder();
                foreach(string item in words)
                {
                    if(sb.Length == 0)
                    {
                        sb.Append(item);
                    }
                    else
                    {
                        sb.Append("\r\n" + item);
                    }
                    
                }

                

                alteredTextBox.Text = sb.ToString();
                

                //MessageBox.Show("The word with the most vowels is: " + wordWithMostVowels);

                statisticsTextBox.Text = "The first word alphabetically is: " + firstWord + "\r\nThe last word alphabetically is: " + lastWord +
                                         "\r\nThe longest word is: " + longestWord + "\r\nThe word with the most vowels is: " + wordWithMostVowels;
               
            }
        }

        private void convertEachToLowerCase( string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string s = array[i];
                array[i] = s.ToLower();
            }

        }

        private string findLongestWord(string[] array)
        {

            int longestWordIndex = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int string1 = array[longestWordIndex].Length;
                int string2 = array[i].Length;

                if(string1 < string2){

                    longestWordIndex = i;
                }
             
            }

            return array[longestWordIndex].ToString();

        }

        private string findWordWithMostVowels(string[] array)
        {
            int mostVowelsIndex = 0;
            int highestVowelCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {

                int vowelsThisString = countVowels(array[i]);

                if(vowelsThisString > highestVowelCount)
                {
                    highestVowelCount = vowelsThisString;
                    mostVowelsIndex = i;
                }

            }

            return array[mostVowelsIndex];
        }

        private int countVowels(string s)
        {
            int vowels = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowels++;
                }
            }

            return vowels;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            StreamWriter outputFile;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(sfd.FileName);
                outputFile.Write(alteredTextBox.Text);
                outputFile.Close();
            }
        }
    }
}
