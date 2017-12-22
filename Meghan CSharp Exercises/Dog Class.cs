using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meghan_CSharp_Exercises
{
    class Dog
    {
        public string Name { get; set; } //shorthand that states programmer will get data and it
        public string Owner { get; set; } //should be set in property

        public void Speak() //void = return type - returns nothing, when Speak() called 
        {                   //only logs once to console
            Console.WriteLine("Woof!");
        }
        public string Talk() //string = return type - stores "Bark!" into var msg in 
        {                    //Examples and Notes.cs; can be reused
            return "Bark!";
        }
    }
}
