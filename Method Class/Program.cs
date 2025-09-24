using System; // Import the System namespace to use basic classes like Console

namespace MathOperationApp // Declare a namespace for the application
{
    // Define a class named MathProcessor
    class MathProcessor
    {
        // Define a void method named ProcessNumbers that takes two integer parameters
        public void ProcessNumbers(int number1, int number2)
        {
            // Perform a math operation on the first number (e.g., multiply by 2)
            int result = number1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second number as is
            Console.WriteLine("Second number: " + number2);
        }
    }

    // Main class containing the entry point of the application
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathProcessor class
            MathProcessor processor = new MathProcessor();

            // Call the ProcessNumbers method with two integers
            processor.ProcessNumbers(5, 10); // First call: 5 and 10 as positional arguments

            // Call the ProcessNumbers method again using named parameters
            processor.ProcessNumbers(number2: 26, number1: 3); // Named arguments: order doesn't matter

            // Wait for user input to keep the console window open
            Console.ReadLine();
        }
    }
}
