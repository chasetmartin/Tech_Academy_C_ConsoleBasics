using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main()
        {
            //Simple while statement demonstration, assign variable count = 1, then Console.Write the count variable
            //on each iteration of the While loop, adding 1 to the value each time. It counts to ten.
            Console.WriteLine("Simple program counting using a While statement:");
            int count = 1;
            while (count < 11)
            {
                Console.WriteLine(count);
                count++;
            }

            Console.WriteLine("Now please guess a number between 1 and 10 for a little game demonstrating my Do/While statement!");
            //Asking user for an input of an integer between 1 and 10
            int guess = Convert.ToInt32(Console.ReadLine());
            //Seeing if that integer is equal to 8 and assigning the boolean value for true or false
            bool isGuessed = guess == 8;

            //Creating a switch statement within a do while loop to see if the user's guess is correct and ask
            //them for a new guess if it's not correct. The do statement ensures the switch runs at least once
            //even if the user's initial guess is correct.
            do
            {
                //Change background of a bad guess to red
                Console.BackgroundColor = ConsoleColor.Red;
                switch (guess)
                {
                    case 1:
                        Console.WriteLine("You guessed 1, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You guessed 8. Congratulations, YOU WIN!");
                        //8 is the correct number, so we assign true to the boolean isGuessed to end our loop, changed console color to green
                        isGuessed = true;
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10, that is not correct. Try again");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are wrong, and that is not an integer between 1 and 10");
                        Console.WriteLine("Guess another number between 1 and 10");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            
            Console.Read();
        }
    }
}
