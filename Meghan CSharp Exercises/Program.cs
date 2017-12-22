using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meghan_CSharp_Exercises;
using Meghan_CSharp_Exercises.Classes; //must link to folder with classes for them to be used

namespace Meghan_CSharp_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var userChoice = ""; //empty string that will be filled in do/while loop below

            do
            {
                MenuManager.BuildMainMenu();//shows main menu
                do
                {
                    userChoice = MenuManager.GetMainMenuChoice(); //fills var with user choice from main menu

                } while (!Utilities.IsValidInput(userChoice, 1, 6)); //restricts user input to just integers 1-6

                //Execute user's choice - I like this here, makes more sense to me, the programmer :-)
                switch (userChoice)
                {
                    case "1":
                        //Max of Five
                        MenuManager.GetMaxofFiveData();
                        break;
                    case "2":
                        //Palindrome
                        MenuManager.GetPalindromeData();
                        break;
                    case "3":
                        //Longest word
                        MenuManager.GetLongestWordData();
                        break;
                    case "4":
                        //Longer than integer words
                        MenuManager.GetLongWordData();
                        break;
                    case "5":
                        //Order words by frequency
                        MenuManager.GetWordFreqData();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.WriteLine();//Line break
                Console.Write("Press any key to return to the Main Menu.");//Instructions for user; how is this working?
                Console.ReadKey();//runs program until user does something

            } while (true); //outer do/while loop loops through code forever until user exits (hitting 6 in switch statement)
        }
    }
}
