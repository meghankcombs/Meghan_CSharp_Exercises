using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meghan_CSharp_Exercises.Classes
{
    class WordManager
    {
        //Algorithms for String Problems using Constructors

        //See if a word is a Palindrome
        public bool Palindrome(string palin1)
        {
            string first = palin1.Substring(0, palin1.Length / 2);//put input into string and split in half
            char[] arr = palin1.ToCharArray();//put halves into array
            Array.Reverse(arr);//reverse the array
            string temp = new string(arr);//put into new string
            string second = temp.Substring(0, temp.Length / 2);//split new string in half also
            return first.Equals(second);//compare the two strings' halves
        }

        //Find the longest word in a given array of words
        public string longestWord(string userInput)
        {
            var wordArray = userInput.Split(' ');//split list of words by the space
            var longestWord = "";//output
            var longestWords = new StringBuilder();
            //loop through array
            for (var index = 0; index < wordArray.Length; index++)
            {
                if (wordArray[index].Length > longestWord.Length)//compare first word in array to longest word, which starts at 0
                {
                    longestWord = wordArray[index].Trim();//if it's longer than longestWord...
                    longestWords.Clear();
                    longestWords.AppendLine("This is the longest word: " + wordArray[index].Trim());//...store it in longestWords variable
                }
                else if(wordArray[index].Trim().Length == longestWord.Length && wordArray[index].Trim() != longestWord)//if the next word in array equals longestWord variable, then also store it to longestWords
                {
                    longestWords.AppendLine("This is also the longest word: " + wordArray[index].Trim());
                }
            }
            return longestWords.ToString();
        }

        //Find words longer than a given integer
        public string longestInteger(int length, string userInput) {
            var stringArray = userInput.Split(' ');
            var output = new StringBuilder();//more C#-esque way of strings with line breaks
            //var hits = 0;
            for (var loop = 0; loop < stringArray.Length; loop++)
            {
                if (!string.IsNullOrEmpty(stringArray[loop]))
                {
                    if (stringArray[loop].Length > length)
                    {
                        //output = "The word " + stringArray[loop] + " is longer than " + length  + "\r\n";
                        output.AppendLine("The word " + stringArray[loop] + " is longer than " + length);
                        //can only use .AppendLine() when StringBuilder() is used first (like above)
                        //hits += 1;
                    }
                }
            }
            //if(hits == 0)
            if(string.IsNullOrEmpty(output.ToString()))//if output is empty, print this line.
            {
                output.AppendLine("There are no words longer than your number.");
            }

            return output.ToString();
        }

        //Find the most frequent words and order them by frequency (two methods used, wordFrequency and CountOccurrences)
        public string wordFrequency(string userInput) {
            var allWords = userInput.Split(' ');
            var uniqueWords = allWords.Distinct();//removes duplicates and compares individual words 
                                                //in uniqueArray to how many of each are in allWords array
            var output = new StringBuilder();
            foreach (var word in uniqueWords)
            {
                output.AppendLine("The word " + word + " occurrs " + CountOccurrences(word, allWords) + " time(s).");
            }

            output.AppendLine("Here is the order of occurrences: " + wordFreqOrder(allWords));

            return output.ToString();
        }

        //counts how many times a single word is occurring in the allWords array in wordFrequency
        public string CountOccurrences(string word, string[] array)//can use this in wordFrequency method because neither method is static
        {
            var hits = 0;
            foreach (var singleword in array)
            {
                if (singleword == word)
                    hits += 1;
            }

            return hits.ToString();
        }
        
        //LINQ to order wordFrequency by occurrence
        public string wordFreqOrder(string[] array)
        {
                 var result = array.GroupBy(n => n)
                 // Order by the frequency of each group of numbers
                 .OrderBy(g => g.Count())
                 // Then by the natural (alphabetical) order of each number - not needed for 3 inputs
                 //.ThenBy(g => g.Key)
                 // Project the groups back to a flat array
                 .SelectMany(g => g);

            return (string.Join(", ", result));
        }

        //END OF PROGRAMS

        #region Old Code for Word Frequency
        //var allWordsArray = new string[] { freq1, freq2, freq3 };
        ////2D array stores value in one col and count in another
        //var uniqueArray = new string[3];
        //var count = 0;
        //for (var loop = 0; loop < allWordsArray.Length; loop++)
        //{
        //    if(Array.IndexOf(uniqueArray, allWordsArray[loop]) < 0) //searches through arrays
        //    {
        //        uniqueArray[count] = allWordsArray[loop];
        //        count++;
        //    }
        //}

        //var twoDimArray = new string[uniqueArray.Length, 2];
        //var hits = 0;

        //for(var loop = 0; loop < uniqueArray.Length; loop++)
        //{
        //    twoDimArray[loop, 0] = uniqueArray[loop];

        //    foreach (var word in allWordsArray)
        //    {
        //        if(word == uniqueArray[loop])
        //        {
        //            hits += 1;
        //        }
        //    }

        //    twoDimArray[loop, 1] = hits.ToString();
        //    hits = 0;
        //}

        //var output = new StringBuilder();
        //for (var loop = 0; loop < uniqueArray.Length; loop++)
        //{
        //    if (twoDimArray[loop, 0] != null)
        //    {
        //        output.AppendLine("The word " + twoDimArray[loop, 0] + " occurred " + twoDimArray[loop, 1] + " time(s).");
        //    }
        //}

        //return output.ToString();
        #endregion
    }
}
