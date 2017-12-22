using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meghan_CSharp_Exercises.Classes;

namespace Meghan_CSharp_Exercises.Classes
{
    //Algorithm for Integer Problems

    class MathManager
    {
        public static int maxOfFive(int num1, int num2, int num3, int num4, int num5)
        {
            //List of integers
            //var intList = new List<int>(); <-class that takes data type in <>; can loop through (like arrays, but with more operations)
            
            //Create new integer Array
            var intArray = new int[] {num1, num2, num3, num4, num5};
            var largestNum = intArray[0]; //assigning num1 to var largestNum, somewhere to start

            //cycle over remaining elements of intArray
            for (var loop = 1; loop < intArray.Length; loop++) //starts at 1 bc already have 0 assigned above
            {
                if(intArray[loop] > largestNum) //if number in array is larger than num1, then record below
                {
                    largestNum =  intArray[loop]; //record largest number when found in if statement above
                }
            }

            return largestNum;
        }
    }
}
