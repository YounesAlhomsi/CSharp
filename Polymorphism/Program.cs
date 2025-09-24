using System; // Required for Console functionality

namespace PolymorphismDemo // Define a namespace for organizing the code
{
    // Define an interface named IQuittable
    interface IQuittable
    {
        // Declare a void method called Quit
        void Quit();
    }

    // Define the Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Public property to store the employee ID
        public int Id { get; set; }

        // Public property to store the first name
        public string FirstName { get; set; }

        // Public property to store the last name
        public string LastName { get; set; }

        // Implement the Quit method from IQuittable
        public void Quit()
        {
            // Display a message to simulate the employee quitting
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // Main class that runs the console application
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create an instance of Employee and assign values to properties
            Employee emp = new Employee();
            emp.Id = 123;
            emp.FirstName = "Jane";
            emp.LastName = "Doe";

            // Use polymorphism: assign the Employee object to a variable of type IQuittable
            IQuittable quittableEmp = emp;

            // Call the Quit method using the interface reference
            quittableEmp.Quit();

            // Pause the console so we can see the output before the window closes
            Console.ReadLine();
        }
    }
}
