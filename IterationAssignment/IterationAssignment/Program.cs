using System;
using System.Collections.Generic;
using System.Linq;

namespace IterationAssignment
{
    class Program
    {
        static void Main()
        {
            //PART 1:
            //Create one-dimensional array of strings:
            string[] stringArray1 = { "Cat", "Dog", "Rabbit", "Snake" };
            //Ask user to input some text:
            Console.WriteLine("PART 1");
            Console.WriteLine("Please input the first animal that comes to mind and we will append it to our string array items:");
            string userString = Console.ReadLine();
            //A loop that iterates through string array and concatenates user's text to each string:
            for (int i = 0; i < stringArray1.Length; i++)
            {
                stringArray1[i] = stringArray1[i] + " " + userString;
            }
            //create a second loop that prints off each string in the array
            for (int i = 0; i < stringArray1.Length; i++)
            {
                Console.WriteLine("String array item: " + stringArray1[i]);
            }

            //PART 2
            //Create an infinte loop
            Console.WriteLine("PART 2");
            Console.WriteLine("Counting up from 2, Solving the infinite Loop:");
            // for (int i = 0; i >= 0; i++)
                //Fix my infinite loop by creating the bound i <10, instead of >= 0:
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 2);
            }

            //PART 3
            //A loop where the comparison is a "<"
            Console.WriteLine("PART 3");
            Console.WriteLine("Using < operator to only count from 10 to 14:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 10);
            }
            //A loop where the comparison is a "<="
            Console.WriteLine("Using <= operator to count from 10 to 15, one past the last loop:");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i + 10);
            }

            //PART 4
            Console.WriteLine("PART 4");
            //Create a list of strings where each item is unique
            List<string> animals = new List<string>() { "cat", "dog", "rabbit", "snake", "bird", "lizard" };
            //Ask user to search for a string
            Console.WriteLine("OK I've created a list of animals with no duplicates, \nPlease enter an animal to search for (hint, think pets): ");
            //Record user's search
            string userAnimal = Console.ReadLine();
            //Check to see if the list of strings contains the user's input, assign a boolean value for error handling
            bool listContains = animals.Contains(userAnimal);
            //If the listContains boolean is false, I used a while loop to write an error message and ask for an updated input
            while (!listContains)
            {
                Console.WriteLine("Your input is not part of my list, try again: ");
                userAnimal = Console.ReadLine();
                //update the boolean, which will exit the while loop once true
                listContains = animals.Contains(userAnimal);
            }
            //Continue with iteration practice to find the matched input within the list:
            for (int i = 0; i < animals.Count; i++)
            {
                //if statement to console log the result if the iterated item in animals contains the user input
                if (animals[i].Contains(userAnimal))
                {
                    //Write the index of the match to the console
                    Console.WriteLine("Your input \"" + userAnimal + "\" found a match at the list index of: " + $"{i}");
                    //break to end at the first match
                    break;
                }
            }
            Console.WriteLine("\n\n");

            //PART 5
            Console.WriteLine("PART 5");
            //Create a list of strings where there are some duplicate items:
            List<string> animals2 = new List<string>() { "bird", "cat", "dog", "bird", "cat", "rabbit", "snake", "dog", "bird", "lizard", "rabbit" };
            //Ask user to search for a string
            Console.WriteLine("OK Now I've created a list of animals WITH duplicates, \nPlease enter an animal to search for (hint, think pets): ");
            //Record user's search
            string userAnimal2 = Console.ReadLine();
            //Check to see if the list of strings contains the user's input, assign a boolean value for error handling
            bool listContains2 = animals2.Contains(userAnimal2);
            //If the listContains boolean is false, I used a while loop to write an error message and ask for an updated input
            while (!listContains2)
            {
                Console.WriteLine("Your input is not part of my list, try again: ");
                userAnimal2 = Console.ReadLine();
                //update the boolean, which will exit the while loop once true
                listContains2 = animals2.Contains(userAnimal2);
            }
            //Continue with iteration practice to find the matched input within the list:
            for (int i = 0; i < animals2.Count; i++)
            {
                //if statement to console log the result if the iterated item in animals contains the user input
                if (animals2[i].Contains(userAnimal2))
                {
                    //Write the index of the match to the console
                    Console.WriteLine("Your input \"" + userAnimal2 + "\" found a match at the list index of: " + $"{i}");
                    //remove break statement to continue if there is more than one match
                }
            }
            Console.WriteLine("\n\n");

            //PART 6
            Console.WriteLine("PART 6");
            //Create a list of strings that has at least two identical strings in the list:
            Console.WriteLine("This next section iterates through a list and determines if the item is a duplicate, as it goes");
            List<string> animals3 = new List<string>() { "bird", "cat", "dog", "bird", "cat", "rabbit", "snake", "dog", "bird", "lizard", "rabbit" };
            //Creating an empty list of strings to house unique values to compare to along the way
            List<string> comparelist = new List<string>();
            //Foreach loop to iterate through each animal in animals3
            foreach (string animal3 in animals3)
            {
                //If statement to see if the compare list contains an item the loop has already gotten to
                if (comparelist.Contains(animal3))
                {
                    //If the compare list does contain the item, we know it's a duplicate becuase of our else statement below
                    Console.WriteLine(animal3 + " is a duplicate");
                }
                //Else statement to add value to the compare list if it is the item's first instance in the loop.
                else
                {
                    comparelist.Add(animal3);
                    Console.WriteLine(animal3 + " is unique");
                }
            }

            Console.Read();
        }
    }
}
