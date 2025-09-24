using System; // Needed for Console operations

namespace EmployeeComparisonApp // Namespace for the application
{
    // Define the Program class that contains Main method and Employee class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Create the first Employee object and assign property values
            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.FirstName = "Younes";
            emp1.LastName = "Alhomsi";

            // Create the second Employee object and assign property values
            Employee emp2 = new Employee();
            emp2.Id = 102;
            emp2.FirstName = "Alhomsi";
            emp2.LastName = "Younes";

            // Compare the two Employee objects using overloaded '=='
            if (emp1 == emp2)
            {
                Console.WriteLine("Employees are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employees are NOT equal (different Ids).");
            }

            // Pause the console to view results
            Console.ReadLine();
        }

        // Define the Employee class
        class Employee
        {
            // Public property to store Employee ID
            public int Id { get; set; }

            // Public property to store First Name
            public string FirstName { get; set; }

            // Public property to store Last Name
            public string LastName { get; set; }

            // Overload the '==' operator to compare two Employee objects by Id
            public static bool operator ==(Employee emp1, Employee emp2)
            {
                // If both are null, they are equal
                if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                    return true;

                // If one is null, they are not equal
                if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                    return false;

                // Compare Ids
                return emp1.Id == emp2.Id;
            }

            // Overload the '!=' operator as it must be paired with '=='
            public static bool operator !=(Employee emp1, Employee emp2)
            {
                // Use the '==' overload and negate the result
                return !(emp1 == emp2);
            }

            // Override Equals (required when overloading == and !=)
            public override bool Equals(object obj)
            {
                // Check if the object is an Employee
                if (obj is Employee)
                {
                    Employee other = (Employee)obj;
                    return this.Id == other.Id;
                }
                return false;
            }

            // Override GetHashCode (must be consistent with Equals)
            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
            }
        }
    }
}
