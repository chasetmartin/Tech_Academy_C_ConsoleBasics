using System;

namespace BranchingEstimator
{
    class Program
    {
        static void Main()
        {
            //Title and Welcome
            Console.WriteLine("Welcome to Package Express. \nPlease follow the instructions below.");

            //Package Weight and conversion
            Console.WriteLine("Please enter the package weight (to nearest lbs):");
            int packageweight = Convert.ToInt32(Console.ReadLine());

            //Check package weight
            if (packageweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //Package Width and conversion
                Console.WriteLine("Please enter the package width (to nearest inch):");
                int packagewidth = Convert.ToInt32(Console.ReadLine());

                //Package Height and conversion
                Console.WriteLine("Please enter the package height (to nearest inch):");
                int packageheight = Convert.ToInt32(Console.ReadLine());

                //Package length and conversion
                Console.WriteLine("Please enter the package length (to nearest inch):");
                int packagelength = Convert.ToInt32(Console.ReadLine());

                //Branch to see if package is too big
                if (packageheight + packagewidth + packagelength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                //If the package is not too big, it will calculate the estimate
                else
                {
                    decimal estimate = ((packageheight * packagewidth * packagelength * packageweight) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + estimate);
                }
            }
            Console.Read();
        }
    }
}
