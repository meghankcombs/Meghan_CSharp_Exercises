using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meghan_CSharp_Exercises.Classes;

namespace Meghan_CSharp_Exercises.Classes
{
    public class MenuManager
    {
        //Main Menu
        public static void BuildMainMenu()
        {
            Console.Clear();
            var menuText = new StringBuilder();
            menuText.AppendLine("Meghan's C# Exercises");
            menuText.AppendLine("");
            menuText.AppendLine("1. Maximum of Five Numbers");
            menuText.AppendLine("2. Define a Palindrome");
            menuText.AppendLine("3. Find the Longest Word");
            menuText.AppendLine("4. Filter Long Words");
            menuText.AppendLine("5. Word Frequency");
            menuText.AppendLine("6. Quit");
            //Print the contents of menuText to the Screen
            Console.WriteLine(menuText);
        }

        public static string GetMainMenuChoice()//have to have return statement bc not void return type
        {
            Console.Write("Please choose one of the above exercises (1-5): ");
            return Console.ReadLine();
        }

        //User input for all problems
        public static void GetMaxofFiveData()//has notes about instance for a static method (see MathManager)
        {
            string num1, num2, num3, num4, num5;

            Console.Clear(); //clears console screen
            var msg = new StringBuilder();
            msg.AppendLine("Thanks for choosing Maximum of Five Numbers Exercise. Enter five numbers below:");

            Console.WriteLine(msg);

            //Five sets of console write and console read to prompt user and get input
            //Do/while loops to make sure user inputting only numbers
            do
            {
                Console.Write("Please enter first number: ");
                num1 = Console.ReadLine();
            }
            while (!Utilities.IsValidInput(num1)); //repeat this loop

            do
            {
                Console.Write("Please enter second number: ");
                num2 = Console.ReadLine();
            }
            while (!Utilities.IsValidInput(num2));

            do
            {
                Console.Write("Please enter third number: ");
                num3 = Console.ReadLine();
            }
            while (!Utilities.IsValidInput(num3));

            do
            {
                Console.Write("Please enter fourth number: ");
                num4 = Console.ReadLine();
            }
            while (!Utilities.IsValidInput(num4));

            do
            {
                Console.Write("Please enter fifth number: ");
                num5 = Console.ReadLine();
            }
            while (!Utilities.IsValidInput(num5));

            
            var maxNumber = MathManager.maxOfFive(Convert.ToInt32(num1),//this is NOT an instance because it's static
                                                  Convert.ToInt32(num2),
                                                  Convert.ToInt32(num3),
                                                  Convert.ToInt32(num4),
                                                  Convert.ToInt32(num5));
            Console.WriteLine("The maximum number is: " + maxNumber);
        }

        public static void GetPalindromeData()
        {
            var myWordMgr = new WordManager(); //this is an instance of class WordManager

            string palin1;

            Console.Clear();
            var msg = new StringBuilder();
            msg.AppendLine("Thanks for choosing Palindrome Exercise. Enter a word below:");

            Console.WriteLine(msg);

            do
            {
                Console.Write("Please enter a word: ");
                palin1 = Console.ReadLine();

            } while (!Utilities.IsValidInputAlpha("Alpha", palin1));


            Console.WriteLine("Your word is a Palindrome: " + myWordMgr.Palindrome(palin1));
        }

        public static void GetLongestWordData()
        {
            var myWordMngr = new WordManager();//this is an instance of WordManager

            string userInput;

            Console.Clear();
            var msg = new StringBuilder();
            msg.AppendLine("Thanks for choosing the Longest Word Exercise.");

            Console.WriteLine(msg);

            do
            {
                Console.Write("Please enter a list of words separated by a comma: ");
                userInput = Console.ReadLine();
            } while (!Utilities.IsValidInputAlpha("Alpha", userInput));

            #region Old user input code
            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    longest1 = Console.ReadLine();
            //} while (!Utilities.IsValidInputAlpha("Alpha", longest1));

            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    longest2 = Console.ReadLine();
            //} while (!Utilities.IsValidInputAlpha("Alpha", longest2));
            #endregion

            Console.WriteLine(myWordMngr.longestWord(userInput));
        }

        public static void GetLongWordData()//has notes about logging output to console for a non-static method (see WordManager)
        {
            var myWordMngr = new WordManager(); //instance of class WordManager; WordManager = class, and we're creating a new type

            string length;
            string userInput;

            Console.Clear();
            var msg = new StringBuilder();
            msg.AppendLine("Thanks for choosing the Longest Word Compared to an Integer Exercise.");

            Console.WriteLine(msg);

            do
            {
                Console.Write("Please enter a number: ");
                length = Console.ReadLine();//can't convert user input to integer
            }
            while (!Utilities.IsValidInput(length));

            do
            {
                Console.Write("Please enter a list of words separated by a comma: ");
                userInput = Console.ReadLine();
            } while (!Utilities.IsValidInputAlpha("Alpha", userInput));

            #region Old code for user input
            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    word2 = Console.ReadLine();
            //} while (!Utilities.IsValidInputAlpha("Alpha", word2));

            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    word3 = Console.ReadLine();
            //} while (!Utilities.IsValidInputAlpha("Alpha", word3));
            #endregion

            Console.WriteLine(myWordMngr.longestInteger(Convert.ToInt32(length), userInput));//converted length that was a string because of user input to integer
            //longestInteger = name of method; (length, word1, etc...) = method inputs
        }

        public static void GetWordFreqData()
        {
            var wordMngr = new WordManager(); //this is an instance of WordManager class

            string userInput;

            Console.Clear();
            var msg = new StringBuilder();
            msg.AppendLine("Thanks for choosing the Word Frequency Exercise.");

            Console.WriteLine(msg);

            do
            {
                Console.Write("Please enter a list of words separated by a comma: ");
                userInput = Console.ReadLine();
            }
            while (userInput == "");

            #region Old userinput code
            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    freq2 = Console.ReadLine();
            //}
            //while (freq2 == "");

            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    freq3 = Console.ReadLine();
            //}
            //while (freq3 == "");

            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    freq1 = Console.ReadLine();
            //}
            //while (freq4 == "");

            //do
            //{
            //    Console.Write("Please enter a word: ");
            //    freq1 = Console.ReadLine();
            //}
            //while (freq5 == "");
            #endregion

            Console.WriteLine(wordMngr.wordFrequency(userInput));
        }
    }
}
