using System;

namespace myConsoleProject
{
    class MainClass
    {
        public static void Main()
        {
            //Title
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //Name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //Course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            //Page number
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
                //Convert ReadLine string response to integer
                int pagenumber = Convert.ToInt32(page);
            //Help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
                //Convert ReadLine string response to boolean
                bool helpboolean = Convert.ToBoolean(help);
            //Positives
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string positives = Console.ReadLine();
            //Feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //Hours of Study
            Console.WriteLine("How many hours did you study?");
            string hoursstring = Console.ReadLine();
                //Convert ReadLine string response to double
                double hoursstudied = Convert.ToDouble(hoursstring);
            //Thank you
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
