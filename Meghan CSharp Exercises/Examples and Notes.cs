using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meghan_CSharp_Exercises
{
    class Examples_Notes
    {
        static void Main(string[] args)
        {
            #region Example Code Day1
            //region makes code collapsable

            //Text based menu
            //var menuText = "1. maxOfFive()";
            //Console.WriteLine(menuText);

            //var someVar = "Hello";
            //someVar = 3; //cant change var type
            //var someVar2 = 4;

            //Attempt 1
            //Console.WriteLine("1. maxOfFive()");
            //Console.WriteLine("2. palindrome()");
            //Console.WriteLine("3. findLongestWord()");
            //Console.WriteLine("4. filterLongestWord()");
            //Console.WriteLine("5. wordFreq()");

            //Attempt 2
            //More sophisticated than Attempt 1
            //var menuText = new StringBuilder(); //Class that creates string
            //menuText.AppendLine("1. maxOfFive()");
            //menuText.AppendLine("2. palindrome()");
            //menuText.AppendLine("3. findLongestWord()");
            //menuText.AppendLine("4. filterLongestWord()");
            //menuText.AppendLine("5. wordFreq()");

            //Console.WriteLine(menuText.ToString()); 
            //StringBuilder is an object that has 
            //properties that contains strings, it's
            //not an actual string and must be made a string with .ToString()

            //Console.Write("Enter a selection between 1 and 5: ");
            ////User's choice
            //var userChoice = Console.ReadLine();

            //Console.WriteLine("You chose " + userChoice);
            #endregion

            #region Dog Class implementation

            //Class defined in Dog Class.cs folder
            //showing different return types

            var myDog = new Dog();
            myDog.Name = "Chester";
            myDog.Owner = "Jason";

            Console.WriteLine(myDog.Name); //Logs "Chester" to console
            Console.WriteLine(myDog.Owner); //Logs "Jason" to console
            myDog.Speak();

            var msg = myDog.Talk(); //stores "Bark!" to variable "msg"
            Console.WriteLine(msg); //Logs "Bark!" to console

            Console.WriteLine(myDog.Talk()); //Shortcut to logging "Bark!" from Talk() to console

            #endregion

            //Keep console open (trick)
            Console.ReadKey();
        }
    }
}
