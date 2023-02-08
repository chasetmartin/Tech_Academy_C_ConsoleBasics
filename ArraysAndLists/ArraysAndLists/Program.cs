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
            //while loop to display error message and ask user for new input if input is out of bounds
            while (stringindex < 0 || stringindex >= 6)
            {
                Console.WriteLine("The index value you entered does not exist! Try another index value:");
                stringindex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The value at the index of " + stringindex + " is \"" + stringarray[stringindex] + "\"");

            //One-dimensional array of integers
            int[] intArray = { 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("OK, now there is a hidden array of integers. \nPlease choose an index between 0 and 6 to return the integer value at your specified index:");
            //Save user requested index as integer
            int intIndex = Convert.ToInt32(Console.ReadLine());
            //while loop to display error message and ask user for new input if input is out of bounds
            while (intIndex < 0 || intIndex >= 7)
            {
                Console.WriteLine("The index value you entered does not exist! Try another index value:");
                intIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The value at the index of " + intIndex + " is " + intArray[intIndex]);

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
            //while loop to display error message and ask user for new input if input is out of bounds
            while (stringIndex2 < 0 || stringIndex2 >= 5)
            {
                Console.WriteLine("The index value you entered does not exist! Try another index value:");
                stringIndex2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The string at the index of " + stringIndex2 + " is \"" + stringList[stringIndex2] + "\"");

            Console.Read();

        }
    }
}
