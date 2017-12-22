using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meghan_CSharp_Exercises.Classes;
using System.Text.RegularExpressions;

namespace Meghan_CSharp_Exercises.Classes
{
    class Utilities
    {
        //Constructors - IsValidInput, Numeric

        public static bool IsValidInput(string input, int low, int high)//Using in Program class with userChoice
        {
            int output;
            bool isGood = false;
            if (Int32.TryParse(input, out output))//converts string to integer
            {
                if (output >= low && output <= high)//if integer bewteen the low and high values, program will run
                                                    //if not program won't run (returns false)
                {
                    isGood = true;
                }
            }
            return isGood;
        }

        public static bool IsValidInput(string input)//Using in GetMaxofFiveData() & GetLongWordData() in MenuManager class
        {
            int output;
            return Int32.TryParse(input, out output);
            //if a string is input, it's tested here to see if it can be turned into integer; returns true or false
        }

        //Constructor - IsValidInputAlpha, Alphabetic

        public static bool IsValidInputAlpha(string type, string input)//Using with GetPalindromeData(), GetLongestWordData(), GetLongWordData() in MenuManager
        {
            var result = false;
            Regex regex = null;

            switch (type)
            {
                case "Alpha":
                    regex = new Regex("^[a-zA-Z, ]+$");
                    break;
            }

            if (regex.IsMatch(input))//catching here for some reason..."Object not pointing to an instance... etc"
            {
                result = true;
            }

            return result;
        }
    }
}
