using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //Title and ask age, convert string to int
            Console.WriteLine("Car Insurance Qualification \nWhat is your age?");
            string agestring = Console.ReadLine();
            int age = Convert.ToInt16(agestring);

            //DUI
            Console.WriteLine("Have you ever had a DUI? Write 'true' or 'false'");
            string duistring = Console.ReadLine();
            bool dui = Convert.ToBoolean(duistring);

            //Speeding Tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketstring = Console.ReadLine();
            int tickets = Convert.ToInt16(ticketstring);

            //Qualified logic
            Console.WriteLine("Are you qualified?");
            bool qualified = (age > 15 && dui == false && tickets <= 3);
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}
