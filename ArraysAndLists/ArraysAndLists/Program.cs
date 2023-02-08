using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //One-dimensional array of strings
            string[] stringarray = { "This", "is", "an", "array", "of", "strings" };
            Console.WriteLine("There is a hidden array of strings. \nPlease choose an index between 0 and 5 to return the string value at your specified index:");
            //Save user requested index as integer
            int stringindex = Convert.ToInt32(Console.ReadLine());
            //If/else statement to return the specific index, or start the program over with an error message
            if (stringindex <= 5)
            {
                Console.WriteLine("The value at the index of " + stringindex + " is \"" + stringarray[stringindex] + "\"");
            }
            else
            {
                Console.WriteLine("The index value you entered does not exist! Restarting...");
                Main();
            }

            //One-dimensional array of integers
            int[] intArray = { 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("OK, now there is a hidden array of integers. \nPlease choose an index between 0 and 6 to return the integer value at your specified index:");
            //Save user requested index as integer
            int intIndex = Convert.ToInt32(Console.ReadLine());
            //If/else statement to return the specific index, or start the program over with an error message
            if (intIndex <= 6)
            {
                Console.WriteLine("The value at the index of " + intIndex + " is " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("The index value you entered does not exist! Restarting from the top...");
                Main();
            }

            //One-dimensional list of strings
            List<string> stringList = new List<string>();
            stringList.Add("Here");
            stringList.Add("is");
            stringList.Add("a");
            stringList.Add("string");
            stringList.Add("list");
            Console.WriteLine("OK, now there is a hidden list of strings. \nPlease choose an index between 0 and 4 to return the string value at your specified index:");
            //Save user requested index as integer
            int stringIndex2 = Convert.ToInt32(Console.ReadLine());
            //If/else statement to return the specific index, or start the program over with an error message
            if (stringIndex2 <= 4)
            {
                Console.WriteLine("The string at the index of " + stringIndex2 + " is \"" + stringList[stringIndex2] + "\"");
            }
            else
            {
                Console.WriteLine("The index value you entered does not exist! Restarting from the top...");
                Main();
            }

            Console.Read();

        }
    }
}
