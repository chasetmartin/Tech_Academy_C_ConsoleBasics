using System;

namespace MathComparisonOperators
{
    class MainClass
    {
        public static void Main()
        {
            //Title
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 Hourly Rate & Conversion
            Console.WriteLine("Person 1: \nHourly Rate?");
            string person1rate = Console.ReadLine();
            decimal person1hourly = Convert.ToDecimal(person1rate);

            //Person 1 Hours worked and Conversion
            Console.WriteLine("Hours worked per week?");
            string person1work = Console.ReadLine();
            decimal person1hours = Convert.ToDecimal(person1work);

            //Person 2 Hourly Rate & Conversion
            Console.WriteLine("Person 2: \nHourly Rate?");
            string person2rate = Console.ReadLine();
            decimal person2hourly = Convert.ToDecimal(person2rate);

            //Person 2 Hours worked and Conversion
            Console.WriteLine("Hours worked per week?");
            string person2work = Console.ReadLine();
            decimal person2hours = Convert.ToDecimal(person2work);

            //Annual Salaries Calculation
            decimal person1annualsalary = person1hourly * person1hours * 52;
            decimal person2annualsalary = person2hourly * person2hours * 52;
            Console.WriteLine("Annual salary of Person 1: $" + person1annualsalary);
            Console.WriteLine("Annual salary of Person 2: $" + person2annualsalary);

            //Does person 1 make more than person 2?
            bool person12compare = person1annualsalary > person2annualsalary;
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + person12compare);
            Console.Read();
        }
    }
}
