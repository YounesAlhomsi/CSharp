using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a nice welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the weight of the package
            Console.Write("Please enter the package weight: ");
            // Read and convert the weight input to a number
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                // Display error and exit if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt the user to enter the width of the package
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the height of the package
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the length of the package
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the sum of the dimensions is greater than 50
            if ((width + height + length) > 50)
            {
                // Display error and exit if too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the quote using the given formula
            // volume = width * height * length
            // cost = (volume * weight) / 100
            double quote = (width * height * length * weight) / 100;

            // Display the final quote formatted to two decimal places
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!!");
        }
    }
}
